// <copyright file="AppDriverCommand.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Values describing the list of commands related to application automation as extention to the JSON wire protocol.
    /// </summary>
    public static class AppDriverCommand
    {
        /// <summary>
        /// Represents the DeviceId literal.
        /// </summary>
        public static readonly string DeviceId = "deviceId";

        /// <summary>
        /// Represents the AppId literal.
        /// </summary>
        public static readonly string AppId = "appId";

        /// <summary>
        /// Represents the AppVersion literal.
        /// </summary>
        public static readonly string AppVersion = "appVersion";

        /// <summary>
        /// Represents the SessionId literal.
        /// </summary>
        public static readonly string SessionId = "sessionId";

        /// <summary>
        /// Represents the ElementId literal.
        /// </summary>
        public static readonly string ElementId = "elementId";

        /// <summary>
        /// Represents the PropertyName literal.
        /// </summary>
        public static readonly string PropertyName = "propertyName";

        /// <summary>
        /// Represents the TakeScreenshot command.
        /// </summary>
        public static readonly string TakeScreenshot = "takeScreenshot";

        /// <summary>
        /// Represents the GetApplications command.
        /// </summary>
        public static readonly string GetApplications = "getApplications";

        /// <summary>
        /// Represents the GetDevices command.
        /// </summary>
        public static readonly string GetDevices = "getDevices";

        /// <summary>
        /// Represents the GetTimeouts command.
        /// </summary>
        public static readonly string GetTimeouts = "getTimeouts";

        /// <summary>
        /// Represents the GetDeviceInformation command.
        /// </summary>
        public static readonly string GetDeviceInformation = "getDeviceInformation";

        /// <summary>
        /// Represents the GetInstalledApplications command.
        /// </summary>
        public static readonly string GetInstalledApplications = "getInstalledApplications";

        /// <summary>
        /// Represents the DeleteApplication command.
        /// </summary>
        public static readonly string DeleteApplication = "deleteApplication";

        /// <summary>
        /// Represents the DeleteSettings command.
        /// </summary>
        public static readonly string DeleteSettings = "deleteSettings";

        /// <summary>
        /// Represents the InstallApplication2 command.
        /// </summary>
        public static readonly string InstallApplication2 = "installApplication2";

        /// <summary>
        /// Represents the InstallApplication command.
        /// </summary>
        public static readonly string InstallApplication = "installApplication";

        /// <summary>
        /// Represents the RebootDevice command.
        /// </summary>
        public static readonly string RebootDevice = "rebootDevice";

        /// <summary>
        /// Represents the start app command.
        /// </summary>
        public static readonly string StartApplication = "startApplication";

        /// <summary>
        /// Represents the kill app command.
        /// </summary>
        public static readonly string KillApplication = "killApplication";

        /// <summary>
        /// Represents the IsReady command.
        /// </summary>
        public static readonly string IsReady = "isReady";

        /// <summary>
        /// Represents the GetProperty command.
        /// </summary>
        public static readonly string GetProperty = "getProperty";

        /// <summary>
        /// Represents the GetSessions command.
        /// </summary>
        public static readonly string GetSessions = "sessions";

        /// <summary>
        /// Represents the ElementByCoordinates command.
        /// </summary>
        public static readonly string ElementByCoordinates = "elementByCoordinates";

        /// <summary>
        /// Represents the ClickByCoordinate command.
        /// </summary>
        public static readonly string ClickByCoordinate = "clickByCoordinate";

        /// <summary>
        /// Represents the RemoveSession command.
        /// </summary>
        public static readonly string RemoveSession = "removeSession";

        /// <summary>
        /// Represents the GetStatus command.
        /// </summary>
        public static readonly string GetStatus = "status";

        /// <summary>
        /// Represents the ClearText command.
        /// </summary>
        public static readonly string ClearText = "clear";

        /// <summary>
        /// Represents the ScrollTo command.
        /// </summary>
        public static readonly string ScrollTo = "scrollTo";

        /// <summary>
        /// Represents the DismissKeyboard command.
        /// </summary>
        public static readonly string DismissKeyboard = "dismissKeyboard";

        /// <summary>
        /// Represents the FlickCoordinate command.
        /// </summary>
        public static readonly string FlickCoordinate = "flickCoordinate";
    }
}
