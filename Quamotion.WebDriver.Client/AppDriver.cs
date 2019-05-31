// <copyright file="AppDriver.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Quamotion.WebDriver.Client.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Provides access to the remote WebDriver.
    /// </summary>
    public class AppDriver : RemoteWebDriver, IHasTouchScreen
    {
        public const string PredicateString = "PredicateString";

        public const string ClassChain = "ClassChain";

        /// <summary>
        /// Initializes a new instance of the <see cref="AppDriver"/> class.
        /// </summary>
        /// <param name="desiredCapabilities">
        /// An <see cref="MobileCapabilities"/> object containing the desired capabilities of the application.
        /// </param>
        public AppDriver(MobileCapabilities desiredCapabilities)
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
        /// Finds an element matching the given mechanism and value.
        /// </summary>
        /// <param name="mechanism">
        /// The mechanism by which to find the element.
        /// </param>
        /// <param name="value">
        /// The value to use to search for the element.
        /// </param>
        /// <returns>
        /// The first OpenQA.Selenium.IWebElement matching the given criteria.
        /// </returns>
        public new IWebElement FindElement(string mechanism, string value)
        {
            return base.FindElement(mechanism, value);
        }

        public static Dictionary<string, object> GetDeviceSettings(string deviceId, string domain)
        {
            return WebDriverExtensions.ExecuteCommand<Dictionary<string, object>>(AppDriverCommand.GetDeviceSettings, new Dictionary<string, object>()
            {
                { "deviceId", deviceId },
                { "domain", domain }
            });
        }

        public static object GetDeviceSetting(string deviceId, string domain, string key)
        {
            return WebDriverExtensions.ExecuteCommand<object>(AppDriverCommand.GetDeviceSetting, new Dictionary<string, object>()
            {
                { "deviceId", deviceId },
                { "domain", domain },
                { "key", key }
            });
        }

        /// <summary>
        /// Finds all elements matching the given mechanism and value.
        /// </summary>
        /// <param name="mechanism">
        /// The mechanism by which to find the elements.
        /// </param>
        /// <param name="value">
        /// The value to use to search for the elements.
        /// </param>
        /// <returns>
        /// All OpenQA.Selenium.IWebElement matching the given criteria.
        /// </returns>
        public new ReadOnlyCollection<IWebElement> FindElements(string mechanism, string value)
        {
            return base.FindElements(mechanism, value);
        }

        /// <summary>
        /// Test if an element matches the given mechanism and value.
        /// Test elements does take the implicit time into account.
        /// </summary>
        /// <param name="mechanism">
        /// The mechanism by which to find the elements.
        /// </param>
        /// <param name="value">
        /// The value to use to search for the elements.
        /// </param>
        /// <returns>
        /// Condition representing whether an element is present matching the mechanism and value.
        /// </returns>
        public bool TestElement(string mechanism, string value)
        {
            try
            {
                return this.FindElement(mechanism, value) != null;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Test if any element matches the given mechanism and value.
        /// Test elements does not take the implicit time into account.
        /// </summary>
        /// <param name="mechanism">
        /// The mechanism by which to find the elements.
        /// </param>
        /// <param name="value">
        /// The value to use to search for the elements.
        /// </param>
        /// <returns>
        /// Condition representing whether an element is present matching the mechanism and value.
        /// </returns>
        public bool TestElements(string mechanism, string value)
        {
            try
            {
                return this.FindElements(mechanism, value)?.Any() == true;
            }
            catch
            {
                return false;
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