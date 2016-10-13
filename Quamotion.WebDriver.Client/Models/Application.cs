// <copyright file="Application.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents an application which is being managed by this server.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Gets or sets an ID that uniquely identifies this app. This ID is operating-system specific.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a user-friendly display name of the application.
        /// </summary>
        [JsonProperty("DisplayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the version of this app.
        /// </summary>
        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the version display name of this app.
        /// </summary>
        [JsonProperty("VersionDisplayName", NullValueHandling = NullValueHandling.Include)]
        public string VersionDisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the configuration (type of devices) on which this app can run.
        /// </summary>
        [JsonProperty("SupportedConfigurations", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceConfiguration SupportedConfigurations
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the version of the Quamotion Test Server that is embedded in the
        /// application.
        /// </summary>
        public string TestServerVersion
        {
            get;
            set;
        }
    }
}