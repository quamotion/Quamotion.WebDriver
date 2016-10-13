// <copyright file="SessionStatus.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents the status of a session.
    /// </summary>
    public enum SessionStatus
    {
        /// <summary>
        /// The session status is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// The session is being created. The server has received the request to launch a session and is evaluating it;
        /// the create session request may still be rejected.
        /// </summary>
        Creating,

        /// <summary>
        /// The application is being deployed to the device.
        /// </summary>
        Deploying,

        /// <summary>
        /// Deploying the application to the device failed.
        /// </summary>
        DeployFailed,

        /// <summary>
        /// The application is running on the device.
        /// </summary>
        Running,

        /// <summary>
        /// The session is being deleted.
        /// </summary>
        Stopping,

        /// <summary>
        /// The session failed to stop, and the device may be in an unknown state.
        /// </summary>
        StopFailed
    }
}