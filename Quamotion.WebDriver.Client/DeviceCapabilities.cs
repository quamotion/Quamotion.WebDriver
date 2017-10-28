// <copyright file="DeviceCapabilities.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Contains the capabilites needed to start a device session
    /// </summary>
    public class DeviceCapabilities : MobileCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCapabilities"/> class.
        /// </summary>
        /// <param name="deviceId">
        /// The identifier of the device on which to create the device session.
        /// </param>
        public DeviceCapabilities(string deviceId)
            : this(deviceId, true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCapabilities"/> class.
        /// </summary>
        /// <param name="deviceId">
        /// The identifier of the device on which to create the device session.
        /// </param>
        /// <param name="reuseExistingSession">
        /// <see langword="true"/> if an existing compatible session should be reused
        /// otherwise, <see langword="false"/>.
        /// </param>
        public DeviceCapabilities(string deviceId, bool reuseExistingSession)
            : base("Device", deviceId, reuseExistingSession)
        {
        }
    }
}
