// <copyright file="Dimensions.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents physical dimensions of a device.
    /// </summary>
    public class Dimensions
    {
        /// <summary>
        /// Gets or sets the width, in millimeters, of the device.
        /// </summary>
        [JsonProperty("width")]
        public float Width
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the height, in millimeters, of the device.
        /// </summary>
        [JsonProperty("height")]
        public float Height
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the depth, in millimeters, of the device.
        /// </summary>
        [JsonProperty("depth")]
        public float Depth
        {
            get;
            set;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{this.Width} x {this.Height} x {this.Depth}";
        }
    }
}