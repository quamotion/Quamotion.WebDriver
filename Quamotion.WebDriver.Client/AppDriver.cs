// <copyright file="AppDriver.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Quamotion.WebDriver.Client.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Provides access to the remote WebDriver.
    /// </summary>
    public class AppDriver : RemoteWebDriver, IHasTouchScreen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppDriver"/> class.
        /// </summary>
        /// <param name="desiredCapabilities">
        /// An <see cref="AppCapabilities"/> object containing the desired capabilities of the application.
        /// </param>
        public AppDriver(AppCapabilities desiredCapabilities)
            : base(WebDriverExtensions.GetDefaultCommandExecutor(), desiredCapabilities)
        {
        }

        /// <summary>
        /// Gets the <see cref="ITouchScreen"/> accociated with this driver.
        /// </summary>
        public ITouchScreen TouchScreen
        {
            get
            {
                return new RemoteTouchScreen(this);
            }
        }

        /// <summary>
        /// Gets the <see cref="ICommandExecutor"/> used in this <see cref="AppDriver"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="ICommandExecutor"/> used in this <see cref="AppDriver"/>.
        /// </returns>
        internal TypedHttpCommandExecutor GetCommandExecutor()
        {
            return this.CommandExecutor as TypedHttpCommandExecutor;
        }
    }
}