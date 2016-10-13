//-----------------------------------------------------------------------
// <copyright file="MobileOperatingSystem.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Defines a list of well known mobile operating systems.
    /// </summary>
    public enum MobileOperatingSystem
    {
        /// <summary>
        /// Represents an unknown operating system.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents the Google Android Operating System
        /// </summary>
        Android,

        /// <summary>
        /// Represents the Apple iOS Operating System
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Standard iTunes naming")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1303:Const field names must begin with upper-case letter", Justification = "Standard iOS naming")]
        iOS
    }
}
