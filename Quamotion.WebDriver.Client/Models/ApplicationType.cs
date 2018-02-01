//-----------------------------------------------------------------------
// <copyright file="ApplicationType.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Specifies the type of a mobile application.
    /// </summary>
    public enum ApplicationType
    {
        /// <summary>
        /// The application type is unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The application is a native (compiled) application, such as an <c>.apk</c> on Android or a <c>.ipa</c>
        /// on iOS
        /// </summary>
        Native,

        /// <summary>
        /// The application is a web (HTML, browser)-based application, that can be accessed through an URL.
        /// </summary>
        Web,
        
        /// <summary>
        /// The device application type indicated a device session.
        /// </summary>
        Device
    }
}
