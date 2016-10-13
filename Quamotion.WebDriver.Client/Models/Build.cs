// <copyright file="Build.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using System;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents information about the current build of the Quamotion software running on
    /// the server.
    /// </summary>
    public class Build
    {
        /// <summary>
        /// Gets or sets a generic release label (i.e. "2.0rc3")
        /// </summary>
        [JsonProperty("version")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a specific version number
        /// </summary>
        [JsonProperty("fileVersion")]
        public string FileVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the revision of the local source control client from which the server was built
        /// </summary>
        [JsonProperty("revision")]
        public string Revision
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a timestamp from when the server was built.
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time
        {
            get;
            set;
        }
    }
}
