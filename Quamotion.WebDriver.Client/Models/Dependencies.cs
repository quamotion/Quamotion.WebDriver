// <copyright file="Dependencies.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Contains status information about the Quamotion dependencies.
    /// </summary>
    public class Dependencies
    {
        /// <summary>
        /// Gets or sets a value indicating whether the iMobileDevice library was installed
        /// and loaded correctly.
        /// </summary>
        [JsonProperty("libMobileDeviceInstalled")]
        public bool LibMobileDeviceInstalled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the developer disks that were found on the device.
        /// </summary>
        [JsonProperty("installedDeveloperDisks")]
        public IEnumerable<string> InstalledDeveloperDisks
        {
            get;
            set;
        }
    }
}