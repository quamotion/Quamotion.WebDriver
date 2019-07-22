// <copyright file="Data.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Class used to store the value of a data event.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Data<T>
    {
        /// <summary>
        /// Gets or sets the value of the data event.
        /// </summary>
        [JsonProperty("data")]
        public T Value { get; set; }
    }
}
