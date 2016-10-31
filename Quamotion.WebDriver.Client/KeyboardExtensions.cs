// <copyright file="KeyboardExtensions.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Quamotion extensions for the <see cref="IKeyboard"/> class.
    /// </summary>
    public static class KeyboardExtensions
    {
        /// <summary>
        /// Dismisses the Keyboard.
        /// </summary>
        /// <param name="keyboard">
        /// The keyboard to be dismissed.
        /// </param>
        public static void Dismiss(this IKeyboard keyboard)
        {
            var remoteKeyboardType = typeof(IKeyboard).Assembly.GetType("RemoteKeyboard");
            var driverField = remoteKeyboardType.GetField("driver", BindingFlags.Instance | BindingFlags.NonPublic);

            var driver = driverField.GetValue(keyboard) as AppDriver;
            if (driver == null)
            {
                throw new ArgumentException(nameof(keyboard));
            }

            driver.DismissKeyboard();
        }
    }
}
