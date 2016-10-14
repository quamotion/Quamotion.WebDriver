// <copyright file="WebDriverExtensions.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Quamotion.WebDriver.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Defines additional Quamotion WebDriver routes.
    /// </summary>
    public static class WebDriverExtensions
    {
        /// <summary>
        /// Backing field for the <see cref="DefaultCommandExecutor"/> property.
        /// </summary>
        private static TypedHttpCommandExecutor defaultCommandExecutor;

        /// <summary>
        /// Gets the devices attacted to the <see cref="AppDriver"/>
        /// </summary>
        public static Application[] Applications
        {
            get
            {
                return ExecuteCommand<Application[]>(AppDriverCommand.GetApplications, new Dictionary<string, object>());
            }
        }

        /// <summary>
        /// Gets the devices attacted to the <see cref="AppDriver"/>
        /// </summary>
        public static Session[] Sessions
        {
            get
            {
                var response = ExecuteCommand(AppDriverCommand.GetSessions, new Dictionary<string, object>());
                return GetValue<Session[]>(response);
            }
        }

        /// <summary>
        /// Gets the devices attacted to the <see cref="AppDriver"/>
        /// </summary>
        public static Device[] Devices
        {
            get
            {
                return ExecuteCommand<Device[]>(AppDriverCommand.GetDevices, new Dictionary<string, object>());
            }
        }

        /// <summary>
        /// Gets or sets the default command timeout for HTTP requests in a RemoteWebDriver instance.
        /// </summary>
        public static TimeSpan DefaultCommandTimeout { get; set; } = TimeSpan.FromSeconds(60);

        /// <summary>
        /// Gets the default remote address for this webdriver.
        /// </summary>
        public static Uri DefaultRemoteAddress { get; private set; } = new Uri("http://127.0.0.1:17894/wd/hub");

        /// <summary>
        /// Connects to a remote WebDriver
        /// </summary>
        /// <param name="remoteAddress">
        /// the <see cref="Uri"/> of the remote WebDriver.
        /// </param>
        public static void ConnectTo(Uri remoteAddress)
        {
            DefaultRemoteAddress = remoteAddress;
        }

        /// <summary>
        /// Reboots the device with the given device identifier.
        /// </summary>
        /// <param name="deviceId">
        /// The identifier of the device to reboot.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the reboot operation did succeed;
        /// <see langword="false"/> otherwise
        /// </returns>
        public static bool RebootDevice(string deviceId)
        {
            var response = ExecuteCommand(AppDriverCommand.RebootDevice, new Dictionary<string, object>()
            {
                { AppDriverCommand.DeviceId, deviceId }
            });

            return response.Status == WebDriverResult.Success;
        }

        /// <summary>
        /// Waits until the <see cref="AppDriver"/> is ready.
        /// </summary>
        /// <param name="appDriver">
        /// The <see cref="AppDriver"/> on which to executor the command.
        /// </param>
        public static void WaitUntilReady(this AppDriver appDriver)
        {
            while (!appDriver.IsReady())
            {
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Checks if the <see cref="AppDriver"/> is ready.
        /// </summary>
        /// <param name="appDriver">
        /// The <see cref="AppDriver"/> on which to executor the command.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the <see cref="AppDriver"/> is ready;
        /// otherwise, returns <see langword="false"/>
        /// </returns>
        public static bool IsReady(this AppDriver appDriver)
        {
            var response = appDriver.ExecuteCommand(AppDriverCommand.IsReady, new Dictionary<string, object>());
            return (bool)response.Value;
        }

        /// <summary>
        /// Gets the <c>WebDriver</c> status
        /// </summary>
        /// <param name="appDriver">
        /// The <see cref="AppDriver"/> on which to executor the command.
        /// </param>
        /// <returns>
        /// The <c>WebDriver</c> status
        /// </returns>
        public static Status GetStatus(this AppDriver appDriver)
        {
            var response = appDriver.ExecuteCommand(AppDriverCommand.GetStatus, string.Empty);
            return GetValue<Status>(response);
        }

        /// <summary>
        /// Gets the default <see cref="ICommandExecutor"/>. The <see cref="ICommandExecutor"/> also defines the routes for the Quamotion WebDriver next to the standard <c>WebDriver</c> routes.
        /// </summary>
        /// <returns>
        /// The default command executor to use when automating mobile applications
        /// </returns>
        internal static TypedHttpCommandExecutor GetDefaultCommandExecutor()
        {
            if (defaultCommandExecutor == null)
            {
                var commandInfo = new W3CWireProtocolCommandInfoRepository();
                commandInfo.AddAppCommands();
                defaultCommandExecutor = new TypedHttpCommandExecutor(DefaultRemoteAddress, commandInfo );
            }

            return defaultCommandExecutor;
        }

        /// <summary>
        /// Executes a command on the given <see cref="AppDriver"/>
        /// </summary>
        /// <param name="name">
        /// The name of the command.
        /// </param>
        /// <param name="parameters">
        /// The parameters of the command.
        /// </param>
        /// <returns>
        /// The response of the execution.
        /// </returns>
        private static Response ExecuteCommand(string name, Dictionary<string, object> parameters)
        {
            var command = new Command(null, name, parameters);
            return GetDefaultCommandExecutor().Execute(command);
        }

        /// <summary>
        /// Executes a command on the given <see cref="AppDriver"/>
        /// </summary>
        /// <param name="appDriver">
        /// The <see cref="AppDriver"/> on which to executor the command.
        /// </param>
        /// <param name="name">
        /// The name of the command.
        /// </param>
        /// <param name="parameters">
        /// The parameters of the command.
        /// </param>
        /// <returns>
        /// The response of the execution.
        /// </returns>
        private static Response ExecuteCommand(this AppDriver appDriver, string name, Dictionary<string, object> parameters)
        {
            var command = new Command(appDriver.SessionId, name, parameters);
            var response = appDriver.GetCommandExecutor().Execute(command);
            return response;
        }

        /// <summary>
        /// Executes a command on the given <see cref="AppDriver"/>
        /// </summary>
        /// <param name="appDriver">
        /// The <see cref="AppDriver"/> on which to executor the command.
        /// </param>
        /// <param name="name">
        /// The name of the command.
        /// </param>
        /// <param name="jsonParameters">
        /// The parameters of the command.
        /// </param>
        /// <returns>
        /// The response of the execution.
        /// </returns>
        private static Response ExecuteCommand(this AppDriver appDriver, string name, string jsonParameters)
        {
            var command = new Command(name, jsonParameters);
            var response = appDriver.GetCommandExecutor().Execute(command);
            return response;
        }

        /// <summary>
        /// Executes a command on the given <see cref="AppDriver"/>
        /// </summary>
        /// <typeparam name="T">
        /// The response type
        /// </typeparam>
        /// <param name="name">
        /// The name of the command.
        /// </param>
        /// <param name="parameters">
        /// The parameters of the command.
        /// </param>
        /// <returns>
        /// The response of the execution.
        /// </returns>
        private static T ExecuteCommand<T>(string name, Dictionary<string, object> parameters)
        {
            var command = new Command(null, name, parameters);
            return GetDefaultCommandExecutor().Execute<T>(command);
        }

        /// <summary>
        /// Executes a command on the given <see cref="AppDriver"/>
        /// </summary>
        /// <typeparam name="T">
        /// The response type
        /// </typeparam>
        /// <param name="appDriver">
        /// The <see cref="AppDriver"/> on which to executor the command.
        /// </param>
        /// <param name="name">
        /// The name of the command.
        /// </param>
        /// <param name="parameters">
        /// The parameters of the command.
        /// </param>
        /// <returns>
        /// The response of the execution.
        /// </returns>
        private static T ExecuteCommand<T>(this AppDriver appDriver, string name, Dictionary<string, object> parameters)
        {
            var command = new Command(appDriver.SessionId, name, parameters);
            return appDriver.GetCommandExecutor().Execute<T>(command);
        }

        /// <summary>
        /// Executes a command on the given <see cref="AppDriver"/>
        /// </summary>
        /// <typeparam name="T">
        /// The response type
        /// </typeparam>
        /// <param name="appDriver">
        /// The <see cref="AppDriver"/> on which to executor the command.
        /// </param>
        /// <param name="name">
        /// The name of the command.
        /// </param>
        /// <param name="jsonParameters">
        /// The parameters of the command.
        /// </param>
        /// <returns>
        /// The response of the execution.
        /// </returns>
        private static T ExecuteCommand<T>(this AppDriver appDriver, string name, string jsonParameters)
        {
            var command = new Command(name, jsonParameters);
            return appDriver.GetCommandExecutor().Execute<T>(command);
        }

        /// <summary>
        /// Gets the value of the response as the given type.
        /// </summary>
        /// <typeparam name="T">
        /// The type to be deserialise the result value.
        /// </typeparam>
        /// <param name="response">
        /// THe response for which to get the value
        /// </param>
        /// <returns>
        /// The value of the response.
        /// </returns>
        private static T GetValue<T>(Response response)
        {
            var json = JsonConvert.SerializeObject(response.Value);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
