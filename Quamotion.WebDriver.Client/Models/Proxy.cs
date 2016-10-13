// <copyright file="Proxy.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// A JSON object describing a Proxy configuration.
    /// </summary>
    public class Proxy
    {
        /// <summary>
        /// Gets or sets the type of proxy being used
        /// </summary>
        [JsonProperty("proxyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProxyType ProxyType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URL to be used for proxy autoconfiguration. Expected format
        /// example: <c>http://hostname.com:1234/pacfile</c>
        /// </summary>
        [JsonProperty("proxyAutoconfigUrl")]
        public string ProxyAutoconfigUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the proxy to be used for FTP requests. Behaviour is undefined if a request is
        /// made, where the proxy for the particular protocol is undefined, if proxyType is
        /// manual. Expected format example: <c>hostname.com:1234</c>
        /// </summary>
        [JsonProperty("ftpProxy")]
        public string FtpProxy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the proxy to be used for HTTP requests. Behaviour is undefined if a request is
        /// made, where the proxy for the particular protocol is undefined, if proxyType is
        /// manual. Expected format example: <c>hostname.com:1234</c>
        /// </summary>
        [JsonProperty("httpProxy")]
        public string HttpProxy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the proxy to be used for HTTPS requests. Behaviour is undefined if a request is
        /// made, where the proxy for the particular protocol is undefined, if proxyType is
        /// manual. Expected format example: <c>hostname.com:1234</c>
        /// </summary>
        [JsonProperty("sslProxy")]
        public string SslProxy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the proxy to be used for SOCKS requests. Behaviour is undefined if a request is
        /// made, where the proxy for the particular protocol is undefined, if proxyType is
        /// manual. Expected format example: <c>hostname.com:1234</c>
        /// </summary>
        [JsonProperty("socksProxy")]
        public string SocksProxy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SOCKS proxy username.
        /// </summary>
        [JsonProperty("socksUsername")]
        public string SocksUsername
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SOCKS proxy password.
        /// </summary>
        [JsonProperty("socksPassword")]
        public string SocksPassword
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the proxy bypass addresses. Format is driver specific.
        /// </summary>
        [JsonProperty("noProxy")]
        public string NoProxy
        {
            get;
            set;
        }
    }
}