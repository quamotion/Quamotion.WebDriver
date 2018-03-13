// <copyright file="TypedHttpCommandExecutor.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

namespace Quamotion.WebDriver.Client
{
    internal class TypedHttpCommandExecutor : ICommandExecutor
    {
        private const string ContentTypeHeader = "application/json;charset=utf-8";
        private const string JsonMimeType = "application/json";
        private const string RequestAcceptHeader = "application/json, image/png";

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedHttpCommandExecutor"/> class.
        /// </summary>
        /// <param name="remoteServer">
        /// The <see cref="Uri"/> of the <c>WebDriver</c> server
        /// </param>
        /// <param name="commandInfoRepository">
        /// The <see cref="CommandInfoRepository"/> used to convert <see cref="Command"/> objects to <see cref="WebRequest"/>.
        /// </param>
        public TypedHttpCommandExecutor(Uri remoteServer, CommandInfoRepository commandInfoRepository)
        {
            if (commandInfoRepository == null)
            {
                throw new ArgumentNullException(nameof(commandInfoRepository));
            }

            if (remoteServer == null)
            {
                throw new ArgumentNullException(nameof(remoteServer));
            }

            if (!remoteServer.AbsoluteUri.EndsWith("/", StringComparison.OrdinalIgnoreCase))
            {
                remoteServer = new Uri(remoteServer.ToString() + "/");
            }

            this.RemoteServer = remoteServer;
            ServicePointManager.Expect100Continue = false;
            HttpWebRequest.DefaultMaximumErrorResponseLength = -1;

            this.CommandInfoRepository = commandInfoRepository;
        }

        /// <summary>
        /// Gets or sets the address of the WebDriver Server.
        /// </summary>
        public Uri RemoteServer { get; set; }

        public TimeSpan ServerResponseTimeout { get; set; } = TimeSpan.FromSeconds(60);

        public bool KeepAlive { get; set; } = true;

        public CommandInfoRepository CommandInfoRepository { get; set; }

        /// <inheritdoc />
        public Response Execute(Command command)
        {
            var response = this.Execute<Response>(command);

            if (command.Name == "getPageSource")
            {
                // The .NET Selenium client returns the page source as a string object. However, the Response command will attempt to serialize
                // this as a dictionary. Convert this back to a string value to make sure we return the correct value.
                response.Value = JsonConvert.SerializeObject(response);
            }

            return response;
        }

        /// <summary>
        /// Exectutes a command on the <c>WebDriver</c>
        /// </summary>
        /// <typeparam name="T">
        /// the type of the response.
        /// </typeparam>
        /// <param name="command">
        /// The command to execute
        /// </param>
        /// <returns>
        /// the result of the execution
        /// </returns>
        public virtual T Execute<T>(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(Command));
            }

            var request = this.CreateRequest(command);
            return this.GetResponse<T>(request);
        }

        /// <summary>
        /// Gets the text of a <see cref="WebResponse"/>
        /// </summary>
        /// <param name="webResponse">
        /// The <see cref="WebResponse"/>
        /// </param>
        /// <returns>
        /// The text of the <see cref="WebResponse"/>
        /// </returns>
        private static string GetTextOfWebResponse(HttpWebResponse webResponse)
        {
            StreamReader reader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
            string str = reader.ReadToEnd();
            reader.Close();
            if (str.IndexOf('\0') >= 0)
            {
                str = str.Substring(0, str.IndexOf('\0'));
            }

            return str;
        }

        /// <summary>
        ///  Creates a <see cref="Reponse"/> from a <see cref="HttpWebResponse"/>
        /// </summary>
        /// <param name="webResponse">
        /// The <see cref="HttpWebResponse"/> to convert.
        /// </param>
        /// <returns>
        /// The <see cref="Response"/>
        /// </returns>
        private Response GetResponse(HttpWebResponse webResponse)
        {
            if (webResponse == null)
            {
                throw new NullReferenceException(nameof(webResponse));
            }

            var response = new Response();

            string responseString = GetTextOfWebResponse(webResponse);
            if (webResponse.ContentType != null && webResponse.ContentType.StartsWith(JsonMimeType, StringComparison.OrdinalIgnoreCase))
            {
                response = Response.FromJson(responseString);
            }
            else
            {
                response.Value = responseString;
            }

            return response;
        }

        /// <summary>
        /// Gets the <see cref="WebRequest"/> <c>WebDriver</c> response.
        /// </summary>
        /// <typeparam name="T">
        /// The response type
        /// </typeparam>
        /// <param name="request">
        /// The <see cref="WebRequest"/> to be executed.
        /// </param>
        /// <returns>
        /// The <c>WebDriver</c> response.
        /// </returns>
        private T GetResponse<T>(WebRequest request)
        {
            HttpWebResponse webResponse = null;
            try
            {
                webResponse = request.GetResponse() as HttpWebResponse;
            }
            catch (WebException exception)
            {
                throw new WebDriverException($"A exception was thrown sending an HTTP request to the remote WebDriver server for URL {request.RequestUri.AbsoluteUri}.", exception);
            }

            try
            {
                if (webResponse == null || webResponse.ContentType == null)
                {
                    throw new WebDriverException($"Unsupported webResponse for url {request.RequestUri.AbsoluteUri}");
                }

                string textOfWebResponse = GetTextOfWebResponse(webResponse);

                if (typeof(T) == typeof(Response))
                {
                    var commandResponse = new Response();
                    if (webResponse.ContentType != null && webResponse.ContentType.StartsWith(JsonMimeType, StringComparison.OrdinalIgnoreCase))
                    {
                        commandResponse = Response.FromJson(textOfWebResponse);
                    }
                    else
                    {
                        commandResponse.Value = textOfWebResponse;
                    }

                    if (this.CommandInfoRepository.SpecificationLevel < 1 && (webResponse.StatusCode < HttpStatusCode.OK || webResponse.StatusCode >= HttpStatusCode.BadRequest))
                    {
                        commandResponse.Status = WebDriverResult.UnhandledError;
                        if (webResponse.StatusCode == HttpStatusCode.NotImplemented)
                        {
                            commandResponse.Status = WebDriverResult.UnknownCommand;
                        }
                    }

                    if (commandResponse.Value is string)
                    {
                        // First, collapse all \r\n pairs to \n, then replace all \n with
                        // System.Environment.NewLine. This ensures the consistency of
                        // the values.
                        commandResponse.Value = ((string)commandResponse.Value).Replace("\r\n", "\n").Replace("\n", System.Environment.NewLine);
                    }

                    return (T)((object)commandResponse);
                }
                else
                {
                    return JsonConvert.DeserializeObject<T>(textOfWebResponse);
                }
            }
            finally
            {
                webResponse.Close();
            }
        }

        /// <summary>
        /// Creates a <see cref="HttpWebRequest"/> from a <see cref="Command"/>
        /// </summary>
        /// <param name="command">
        /// The command to transform to a <see cref="HttpWebRequest"/>
        /// </param>
        /// <returns>
        /// The <see cref="HttpWebRequest"/>
        /// </returns>
        private HttpWebRequest CreateRequest(Command command)
        {
            var commandInfo = this.CommandInfoRepository.GetCommandInfo(command.Name);
            var uri = commandInfo.CreateCommandUri(this.RemoteServer, command);
            var request = (HttpWebRequest)HttpWebRequest.Create(uri);
            request.Method = commandInfo.Method;
            request.Timeout = (int)this.ServerResponseTimeout.TotalMilliseconds;
            request.Accept = RequestAcceptHeader;
            request.KeepAlive = this.KeepAlive;
            request.ServicePoint.ConnectionLimit = 0x7d0;
            if (request.Method == "POST")
            {
                string parametersAsJsonString = command.ParametersAsJsonString;
                byte[] bytes = Encoding.UTF8.GetBytes(parametersAsJsonString);
                request.ContentType = "application/json;charset=utf-8";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
            }

            return request;
        }
    }
}
