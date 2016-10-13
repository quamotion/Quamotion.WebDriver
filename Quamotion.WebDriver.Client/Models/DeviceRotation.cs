// <copyright file="DeviceRotation.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Defines the device rotation of an Android device at runtime.
    /// </summary>
    public enum DeviceRotation
    {
        /// <summary>
        /// The device is not rotated
        /// </summary>
        None,

        /// <summary>
        /// The device is rotated with 90 degrees.
        /// </summary>
        Right,

        /// <summary>
        /// The device is rotated with 180 degrees.
        /// </summary>
        Straigt,

        /// <summary>
        /// The device is rotated with 270 degrees.
        /// </summary>
        Left
    }
}
