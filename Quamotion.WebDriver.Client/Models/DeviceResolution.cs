// <copyright file="DeviceResolution.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents the resolution of a <see cref="Device"/>.
    /// </summary>
    public class DeviceResolution
    {
        [JsonProperty("x")]
        public int X
        {
            get;
            set;
        }

        [JsonProperty("y")]
        public int Y
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the width of the device screen, in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int Width
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the height of the device screen, in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int Height
        {
            get;
            set;
        }
    }
}
