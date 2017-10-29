// <copyright file="MobileCapabilities.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using System;

using OpenQA.Selenium.Remote;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Contains the capabilites needed to create a session on a mobile device.
    /// </summary>
    public class MobileCapabilities : DesiredCapabilities
    {
        public MobileCapabilities(string applicationType, string deviceId, bool reuseExistingSession)
        {
            this.SetCapability("deviceId", deviceId);
            this.SetCapability("applicationType", applicationType);

            this.SetCapability("reuseExistingSession", reuseExistingSession);
        }
    }
}
