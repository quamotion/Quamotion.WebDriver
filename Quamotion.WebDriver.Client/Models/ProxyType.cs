// <copyright file="ProxyType.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Specifies the type of proxy being used.
    /// </summary>
    public enum ProxyType
    {
        /// <summary>
        /// A direct connection - no proxy in use,
        /// </summary>
        Direct,

        /// <summary>
        /// Manual proxy settings configured, e.g. setting a proxy for HTTP, a proxy for FTP,
        /// etc,
        /// </summary>
        Manual,

        /// <summary>
        /// Proxy autoconfiguration from a URL
        /// </summary>
        Pac,

        /// <summary>
        /// Proxy autodetection, probably with WPAD
        /// </summary>
        AutoDetect,

        /// <summary>
        /// Use system settings
        /// </summary>
        System
    }
}