// <copyright file="Capabilities.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents the capabilities which are passed to the server when a new session is started.
    /// </summary>
    public class Capabilities
    {
        /// <summary>
        /// Gets or sets the <see cref="Guid"/> of the provider managing the device.
        /// </summary>
        [JsonProperty("providerId")]
        public Guid? ProviderId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the unique ID of the device.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of application that is being launched.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("applicationType")]
        public ApplicationType ApplicationType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ID of the application being launched.
        /// </summary>
        [JsonProperty("appId")]
        public string AppId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the version of the application being launched.
        /// </summary>
        [JsonProperty("appVersion")]
        public string AppVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session should be reused. A session will be reused if and only if there is an exising session for the given application on the given device.
        /// </summary>
        [JsonProperty("reuseExistingSession")]
        public bool ReuseExistingSession
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the application should be
        /// reinstalled on the device when the session is created.
        /// </summary>
        [JsonProperty("reinstallApplication")]
        public bool ReinstallApplication
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the application settings should be
        /// cleared on the device when the session is created.
        /// </summary>
        [JsonProperty("clearApplicationSettings")]
        public bool ClearApplicationSettings
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the browser being used.
        /// </summary>
        [JsonProperty("browserName")]
        public string BrowserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the browser version, or the empty string if unknown.
        /// </summary>
        [JsonProperty("version")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a key specifying which platform the browser is running on.
        /// </summary>
        [JsonProperty("platform")]
        public string Platform
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session supports taking screenshots of
        /// the current page.
        /// </summary>
        [JsonProperty("javascriptEnabled")]
        public bool JavascriptEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session supports taking screenshots
        /// of the current page.
        /// </summary>
        [JsonProperty("takesScreenshot")]
        public bool TakesScreenshot
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session can interact with modal popups,
        /// such as <c>window.alert</c> and <c>window.confirm</c>.
        /// </summary>
        [JsonProperty("handlesAlerts")]
        public bool HandlesAlerts
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session can interact database storage.
        /// </summary>
        [JsonProperty("databaseEnabled")]
        public bool DatabaseEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session can set and query the browser's
        /// location context.
        /// </summary>
        [JsonProperty("locationContextEnabled")]
        public bool LocationContextEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session can interact with the
        /// application cache.
        /// </summary>
        [JsonProperty("applicationCacheEnabled")]
        public bool ApplicationCacheEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session can query for the browser's
        /// connectivity and disable it if desired.
        /// </summary>
        [JsonProperty("browserConnectionEnabled")]
        public bool BrowserConnectionEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session supports CSS selectors when
        /// searching for elements.
        /// </summary>
        [JsonProperty("cssSelectorsEnabled")]
        public bool CssSelectorsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session supports interactions with
        /// storage objects.
        /// </summary>
        [JsonProperty("webStorageEnabled")]
        public bool WebStorageEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session can rotate the current page's
        /// current layout between portrait and landscape orientations (only applies to mobile
        /// platforms).
        /// </summary>
        [JsonProperty("rotatable")]
        public bool Rotatable
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session should accept all SSL
        /// certs by default.
        /// </summary>
        [JsonProperty("acceptSslCerts")]
        public bool AcceptSslCerts
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the session is capable of generating native
        /// events when simulating user input.
        /// </summary>
        [JsonProperty("nativeEvents")]
        public bool NativeEvents
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the details of any proxy to use. If no proxy is specified, whatever the
        /// system's current or default state is used.
        /// </summary>
        [JsonProperty("proxy")]
        public Proxy Proxy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the global properties for this session.
        /// </summary>
        [JsonProperty("global")]
        public Global Global
        {
            get;
            set;
        }
    }
}