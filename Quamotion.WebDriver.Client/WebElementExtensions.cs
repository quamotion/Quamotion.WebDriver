// <copyright file="WebElementExtensions.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Quamotion extensions for the <see cref="IWebElement"/> class.
    /// </summary>
    public static class WebElementExtensions
    {
        /// <summary>
        /// Scrolls until the element with the meta tag marked is visible
        /// </summary>
        /// <param name="webElement">
        /// The scrollable element
        /// </param>
        /// <param name="marked">
        /// The meta tag of the element which should be visible
        /// </param>
        public static void ScrollToMarked(this IWebElement webElement, string marked)
        {
            webElement.GetAppDriver().ScrollTo(webElement, $"//*[@marked='{marked}']");
        }

        /// <summary>
        /// Scrolls until the element with the meta tag marked is visible
        /// </summary>
        /// <param name="webElement">
        /// The scrollable element
        /// </param>
        /// <param name="xpath">
        /// The meta tag of the element which should be visible
        /// </param>
        public static void ScrollTo(this IWebElement webElement, string xpath)
        {
            webElement.GetAppDriver().ScrollTo(webElement, xpath);
        }

        /// <summary>
        /// Scrolls until the element with the meta tag marked is visible
        /// </summary>
        /// <param name="webElement">
        /// The scrollable element
        /// </param>
        /// <param name="xpath">
        /// The xpath of the element which should be visible
        /// </param>
        public static void ScrollDownTo(this IWebElement webElement, string xpath)
        {
            webElement.GetAppDriver().ScrollDownTo(webElement, xpath);
        }

        /// <summary>
        /// Scrolls until the element with the meta tag marked is visible
        /// </summary>
        /// <param name="webElement">
        /// The scrollable element
        /// </param>
        /// <param name="xpath">
        /// The xpath of the element which should be visible
        /// </param>
        public static void ScrollUpTo(this IWebElement webElement, string xpath)
        {
            webElement.GetAppDriver().ScrollUpTo(webElement, xpath);
        }

        /// <summary>
        /// Gets the associated driver
        /// </summary>
        /// <param name="webElement">
        /// The element for which to get the <see cref="AppDriver"/>
        /// </param>
        /// <returns>
        /// The associated <see cref="AppDriver"/>
        /// </returns>
        private static AppDriver GetAppDriver(this IWebElement webElement)
        {
            var remoteWebElementType = typeof(RemoteWebElement);
            var driverField = remoteWebElementType.GetField("driver", BindingFlags.Instance | BindingFlags.NonPublic);
            var driver = driverField.GetValue(webElement) as AppDriver;

            if (driver == null)
            {
                throw new ArgumentException(nameof(webElement));
            }

            return driver;
        }
    }
}
