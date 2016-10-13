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
        /// Backing field for the <see cref="DefaultCommandExecutor"/> property.
        /// </summary>
        private static ICommandExecutor defaultCommandExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppDriver"/> class.
        /// </summary>
        /// <param name="desiredCapabilities">
        /// An <see cref="AppCapabilities"/> object containing the desired capabilities of the application.
        /// </param>
        public AppDriver(AppCapabilities desiredCapabilities)
            : base(DefaultCommandExecutor, desiredCapabilities)
        {
        }

        /// <summary>
        /// Gets the default remote address for this webdriver.
        /// </summary>
        public static Uri DefaultRemoteAddress { get; private set; } = new Uri("http://127.0.0.1:17894/wd/hub");

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
        /// Gets or sets the default <see cref="ICommandExecutor"/>.
        /// </summary>
        private static ICommandExecutor DefaultCommandExecutor
        {
            get
            {
                if (defaultCommandExecutor == null)
                {
                    var httpCommandExecutorType = typeof(ICommandExecutor).Assembly.GetType("OpenQA.Selenium.Remote.HttpCommandExecutor");
                    defaultCommandExecutor = (ICommandExecutor)Activator.CreateInstance(httpCommandExecutorType, new object[] { DefaultRemoteAddress, RemoteWebDriver.DefaultCommandTimeout });
                    defaultCommandExecutor.CommandInfoRepository.AddAppCommands();
                }

                return defaultCommandExecutor;
            }

            set
            {
                defaultCommandExecutor = value;
            }
        }

        /// <summary>
        /// Reboots the device with the given device identifier.
        /// </summary>
        /// <param name="deviceId">
        /// The identifier of the device to reboot.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the reboot operation did succeed;
        /// <see langword="false"/> otherwise
        /// </returns>
        public static bool RebootDevice(string deviceId)
        {
            var statusCommand = new Command(null, AppDriverCommand.RebootDevice, new Dictionary<string, object>()
                {
                    { AppDriverCommand.DeviceId, deviceId }
                });

            var response = DefaultCommandExecutor.Execute(statusCommand);
            return response.Status == WebDriverResult.Success;
        }

        /// <summary>
        /// Connects to a remote WebDriver
        /// </summary>
        /// <param name="remoteAddress">
        /// the <see cref="Uri"/> of the remote WebDriver.
        /// </param>
        public static void ConnectTo(Uri remoteAddress)
        {
            DefaultCommandExecutor = null;
            DefaultRemoteAddress = remoteAddress;
        }

        /// <summary>
        /// Waits until the <see cref="AppDriver"/> is ready.
        /// </summary>
        public void WaitUntilReady()
        {
            while (!this.IsReady())
            {
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Checks if the <see cref="AppDriver"/> is ready.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the <see cref="AppDriver"/> is ready;
        /// otherwise, returns <see langword="false"/>
        /// </returns>
        public bool IsReady()
        {
            var isReadyCommand = new Command(this.SessionId, AppDriverCommand.IsReady, new Dictionary<string, object>());
            return (bool)this.CommandExecutor.Execute(isReadyCommand).Value;
        }

        /// <summary>
        /// Gets the <c>WebDriver</c> status
        /// </summary>
        /// <returns>
        /// The <c>WebDriver</c> status
        /// </returns>
        public Status GetStatus()
        {
            var statusCommand = new Command(AppDriverCommand.GetStatus, string.Empty);
            var response = this.CommandExecutor.Execute(statusCommand);
            return this.GetValue<Status>(response);
        }

        /// <summary>
        /// Gets the value of the response as the given type.
        /// </summary>
        /// <typeparam name="T">
        /// The type to be deserialise the result value.
        /// </typeparam>
        /// <param name="response">
        /// THe response for which to get the value
        /// </param>
        /// <returns>
        /// The value of the response.
        /// </returns>
        private T GetValue<T>(Response response)
        {
            var json = JsonConvert.SerializeObject(response.Value);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}