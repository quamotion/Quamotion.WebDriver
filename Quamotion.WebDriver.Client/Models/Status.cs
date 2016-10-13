// <copyright file="Status.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Contains information about the status of the WebDriver server.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Gets or sets the build of the Quamotion software the server is running.
        /// </summary>
        [JsonProperty("build")]
        public Build Build
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information of the operating system that hosts the Quamotion software.
        /// </summary>
        [JsonProperty("os")]
        public Os Os
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information about the version of the .NET Framework (CLR) that hosts the
        /// Quamotion software.
        /// </summary>
        [JsonProperty("framework")]
        public string Framework
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information about the Quamotion dependencies.
        /// </summary>
        [JsonProperty("dependencies")]
        public Dependencies Dependencies
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date and time at which the license expires.
        /// </summary>
        [JsonProperty("licenseExpires")]
        public DateTime? LicenseExpires
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the unique ID of this computer.
        /// </summary>
        [JsonProperty("machineId")]
        public string ComputerId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the version of the test servers supported by the
        /// various orchestrators.
        /// </summary>
        [JsonProperty("testServerVersions")]
        public Dictionary<MobileOperatingSystem, string> TestServerVersions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a list of well-known files and their status.
        /// </summary>
        [JsonProperty("files")]
        public Dictionary<string, FileStatus> Files
        {
            get;
            set;
        }
    }
}
