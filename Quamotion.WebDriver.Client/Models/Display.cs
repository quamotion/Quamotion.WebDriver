// <copyright file="Display.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Contains information about the screen display of a device.
    /// </summary>
    public class Display
    {
        /// <summary>
        /// Gets or sets the width, in pixels, of the display.
        /// </summary>
        [JsonProperty("width")]
        public int Width
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the height, in pixels, of the display.
        /// </summary>
        [JsonProperty("height")]
        public int Height
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pixels per inch of the display.
        /// </summary>
        [JsonProperty("ppi")]
        public int Ppi
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the diagonal, in inch, of the display.
        /// </summary>
        [JsonProperty("diagonal")]
        public float Diagonal
        {
            get;
            set;
        }
    }
}