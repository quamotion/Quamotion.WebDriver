//-----------------------------------------------------------------------
// <copyright file="DeviceConfiguration.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Specifies a configuration of a device. A device configuration includes the operating system,
    /// operating system version and CPU architecture. You can compare the configuration of a device
    /// with the supported configuration of an app, to determine whether an app can run on a device.
    /// </summary>
    public class DeviceConfiguration
    {
        /// <summary>
        /// Gets or sets the operating system.
        /// </summary>
        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public MobileOperatingSystem OperatingSystem
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the version of the operating system.
        /// </summary>
        [JsonProperty]
        [JsonConverter(typeof(VersionConverter))]
        public Version OperatingSystemVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of processor.
        /// </summary>
        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public CpuType CpuType
        {
            get;
            set;
        }
    }
}
