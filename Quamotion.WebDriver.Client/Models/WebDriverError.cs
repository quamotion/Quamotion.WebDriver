using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Defines the various status command used by the Web Driver protocol.
    /// </summary>
    public enum WebDriverError
    {
        /// <summary>
        /// The command executed successfully.
        /// </summary>
        Success = 0,

        /// <summary>
        ///  A session is either terminated or not started.
        /// </summary>
        NoSuchDriver = 6,

        /// <summary>
        /// An element could not be located on the page using the given search parameters.
        /// </summary>
        NoSuchElement = 7,

        /// <summary>
        /// A request to switch to a frame could not be satisfied because the frame could not be found.
        /// </summary>
        NoSuchFrame = 8,

        /// <summary>
        /// The requested resource could not be found, or a request was received using an HTTP method that
        /// is not supported by the mapped resource.
        /// </summary>
        UnknownCommand = 9,

        /// <summary>
        /// An element command failed because the referenced element is no longer attached to the DOM.
        /// </summary>
        StaleElementReference = 10,

        /// <summary>
        /// An element command could not be completed because the element is not visible on the page.
        /// </summary>
        ElementNotVisible = 11,

        /// <summary>
        /// An element command could not be completed because the element is in an invalid state
        /// (e.g.attempting to click a disabled element).
        /// </summary>
        InvalidElementState = 12,

        /// <summary>
        /// An unknown server-side error occurred while processing the command.
        /// </summary>
        UnknownError = 13,

        /// <summary>
        /// An attempt was made to select an element that cannot be selected.
        /// </summary>
        ElementIsNotSelectable = 15,

        /// <summary>
        /// An error occurred while executing user supplied JavaScript.
        /// </summary>
        JavaScriptError = 17,

        /// <summary>
        /// An error occurred while searching for an element by XPath.
        /// </summary>
        XPathLookupError = 19,

        /// <summary>
        /// An operation did not complete before its timeout expired.
        /// </summary>
        Timeout = 21,

        /// <summary>
        /// A request to switch to a different window could not be satisfied because the window could not be found.
        /// </summary>
        NoSuchWindow = 23,

        /// <summary>
        /// An illegal attempt was made to set a cookie under a different domain than the current page.
        /// </summary>
        InvalidCookieDomain = 24,

        /// <summary>
        /// A request to set a cookie's value could not be satisfied.
        /// </summary>
        UnableToSetCookie = 25,

        /// <summary>
        /// A modal dialog was open, blocking this operation.
        /// </summary>
        UnexpectedAlertOpen = 26,

        /// <summary>
        /// An attempt was made to operate on a modal dialog when one was not open.
        /// </summary>
        NoAlertOpenError = 27,

        /// <summary>
        /// A script did not complete before its timeout expired.
        /// </summary>
        ScriptTimeout = 28,

        /// <summary>
        /// The coordinates provided to an interactions operation are invalid.
        /// </summary>
        InvalidElementCoordinates = 29,

        /// <summary>
        /// IME was not available.
        /// </summary>
        IMENotAvailable = 30,

        /// <summary>
        /// An IME engine could not be started.
        /// </summary>
        IMEEngineActivationFailed = 31,

        /// <summary>
        /// Argument was an invalid selector (e.g.XPath/CSS).
        /// </summary>
        InvalidSelector = 32,

        /// <summary>
        /// A new session could not be created.
        /// </summary>
        SessionNotCreatedException = 33,

        /// <summary>
        /// Target provided for a move action is out of bounds.
        /// </summary>
        MoveTargetOutOfBounds = 34,

        /// <summary>
        /// The arguments passed to a command are either invalid or malformed.
        /// </summary>
        InvalidArgument,

        /// <summary>
        /// Occurs if the given session id is not in the list of active sessions, meaning the session
        /// either does not exist or that it’s not active.
        /// </summary>
        InvalidSessionId,

        /// <summary>
        /// An attempt was made to operate on a modal dialog when one was not open.
        /// </summary>
        NoSuchAlert,

        /// <summary>
        /// A screen capture was made impossible.
        /// </summary>
        UnableToCaptureScreen,

        /// <summary>
        /// The requested command matched a known URL but did not match an method for that URL.
        /// </summary>
        UnknownMethod,

        /// <summary>
        /// Indicates that a command that should have executed properly cannot be supported for
        /// some reason.
        /// </summary>
        UnsupportedOperation
    }
}
