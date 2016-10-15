// <copyright file="Device.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Drawing;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// A POCO-implementation of the <see cref="IDevice"/> interface, which can be serialized
    /// safely using JSON.
    /// </summary>
    public class Device
    {
        /// <inheritdoc/>
        [JsonProperty("configuration")]
        public DeviceConfiguration Configuration
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("deviceRotation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DeviceRotation DeviceRotation
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("manufacturer")]
        public string Manufacturer
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("model")]
        public string Model
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("providerId")]
        public Guid ProviderId
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("serialNumber")]
        public string SerialNumber
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DeviceState State
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DeviceType Type
        {
            get;
            set;
        }

        /// <inheritdoc/>
        [JsonProperty("uniqueId")]
        public string UniqueId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets additional information about the device model, such as the available memory or the
        /// dimensions of the device.
        /// </summary>
        [JsonProperty("deviceModel", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceModel DeviceModel
        {
            get;
            set;
        }
    }
}