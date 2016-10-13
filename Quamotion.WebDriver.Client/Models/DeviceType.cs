//-----------------------------------------------------------------------
// <copyright file="DeviceType.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Defines the kind of a device.
    /// </summary>
    [Flags]
    public enum DeviceType
    {
        /// <summary>
        /// The device type is unknown
        /// </summary>
        Unkown = 0,

        /// <summary>
        /// The device is a physical device.
        /// </summary>
        Physical = 1,

        /// <summary>
        /// The device is an emulator or a simulator.
        /// </summary>
        Emulator = 2,

        /// <summary>
        /// The device is a cloud device.
        /// </summary>
        Cloud = 4,

        /// <summary>
        /// All devices types.
        /// </summary>
        All = Physical | Emulator | Cloud
    }
}
