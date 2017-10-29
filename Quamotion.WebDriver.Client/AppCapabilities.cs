// <copyright file="AppCapabilities.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using OpenQA.Selenium.Remote;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Contains the capabilites needed to launch an application on a device.
    /// </summary>
    public class AppCapabilities : MobileCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCapabilities"/> class.
        /// </summary>
        /// <param name="deviceId">
        /// The identifier of the device on which to install the application.
        /// </param>
        /// <param name="appId">
        /// The identifier of the application to install.
        /// </param>
        public AppCapabilities(string deviceId, string appId)
            : this(deviceId, appId, true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCapabilities"/> class.
        /// </summary>
        /// <param name="deviceId">
        /// The identifier of the device on which to install the application.
        /// </param>
        /// <param name="appId">
        /// The identifier of the application to install.
        /// </param>
        /// <param name="clearApplicationSettings">
        /// <see langword="true"/> if the application should be cleared;
        /// otherwise, <see langword="false"/>.
        /// </param>
        public AppCapabilities(string deviceId, string appId, bool clearApplicationSettings)
            : this(deviceId, appId, null, clearApplicationSettings)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCapabilities"/> class.
        /// </summary>
        /// <param name="deviceId">
        /// The identifier of the device on which to install the application.
        /// </param>
        /// <param name="appId">
        /// The identifier of the application to install.
        /// </param>
        /// <param name="appVersion">
        /// The version of the application to install.
        /// </param>
        /// <param name="clearApplicationSettings">
        /// <see langword="true"/> if the application should be cleared;
        /// otherwise, <see langword="false"/>.
        /// </param>
        public AppCapabilities(string deviceId, string appId, string appVersion, bool clearApplicationSettings)
            :base ("Native", deviceId, true)
        {
            this.SetCapability("deviceId", deviceId);
            this.SetCapability("applicationType", "Native");
            this.SetCapability("appId", appId);
            if (appVersion != null)
            {
                this.SetCapability("appVersion", appVersion);
            }

            this.SetCapability("clearApplicationSettings", clearApplicationSettings);
        }

        /// <summary>
        /// Configures the <see cref="AppCapabilities"/> to reuse a compatible session.
        /// </summary>
        /// <param name="reuseSession">
        /// <see langword="true"/> if an existing compatible session should be reused
        /// otherwise, <see langword="false"/>.
        /// </param>
        public void ReuseSession(bool reuseSession)
        {
            this.SetCapability("reuseExistingSession", reuseSession);
        }
    }
}
