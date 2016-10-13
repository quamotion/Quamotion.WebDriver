// <copyright file="DeviceModel.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents a device model. A device model is a type of device, such as an iPhone 6 or a Nexus 4.
    /// </summary>
    public class DeviceModel
    {
        /// <summary>
        /// Gets or sets the friendly name for this model. For example, iPhone 6.
        /// </summary>
        [JsonProperty("friendlyName")]
        public string FriendlyName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information about the processor used by this model.
        /// </summary>
        [JsonProperty("processor")]
        public string Processor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information about the memory included in this model.
        /// </summary>
        [JsonProperty("memory")]
        public string Memory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information about the form factor (phone or tablet) of this model.
        /// </summary>
        [JsonProperty("formFactor")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FormFactor FormFactor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information about the physical dimensions of this model.
        /// </summary>
        [JsonProperty("dimensions")]
        public Dimensions Dimensions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets information about the screen display of this model.
        /// </summary>
        [JsonProperty("display")]
        public Display Display
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date at which the model was released. You should populate at least the year
        /// and month fields.
        /// </summary>
        [JsonProperty("released")]
        public DateTime Released
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an ID which uniquely defines the model.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    }
}