// <copyright file="Session.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents a WebDriver session.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Gets or sets the ID of this session.
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the time at which the session was created.
        /// </summary>
        public DateTime CreatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the device information to which the session is attached. The returned <see cref="DeviceInfo"/> is used to serialize the device information in a consistent way. The <see cref="Device"/> can have different implementations resulting in different representations.
        /// </summary>
        [JsonProperty(nameof(Device))]
        public Device DeviceInformation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the capabilities of this session.
        /// </summary>
        public Capabilities Capabilities
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status of this session.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public SessionStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="string"/> that contains more information about the session status.
        /// </summary>
        public string StatusMessage
        {
            get;
            set;
        }
    }
}