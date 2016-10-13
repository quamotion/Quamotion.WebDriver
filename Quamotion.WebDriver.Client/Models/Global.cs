// <copyright file="Global.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using System;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Contains global properties for a session.
    /// </summary>
    public class Global
    {
        /// <summary>
        /// Gets or sets a <see cref="Guid"/> which uniquely identifies the scheduled task instance.
        /// </summary>
        [JsonProperty("taskInstanceUuid")]
        public Guid TaskInstanceUuid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="Guid"/> which uniquely identifies the scheduled task.
        /// </summary>
        [JsonProperty("taskUuid")]
        public Guid TaskUuid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="Guid"/> which uniquely identifies the run.
        /// </summary>
        [JsonProperty("uuid")]
        public Guid Uuid
        {
            get;
            set;
        }
    }
}