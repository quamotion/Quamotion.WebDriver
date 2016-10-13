// <copyright file="Os.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    public class Os
    {
        /// <summary>
        /// Gets or sets the current system architecture.
        /// </summary>
        [JsonProperty("arch")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProcessorArchitecture Arch
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the operating system the server is currently running on: "windows", "linux", etc.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the operating system version.
        /// </summary>
        [JsonProperty("version")]
        public string Version
        {
            get;
            set;
        }
    }
}
