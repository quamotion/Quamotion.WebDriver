using Quamotion.WebDriver.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// The exception that is thrown when a WebDriver-related error occurs.
    /// </summary>
    public class WebDriverException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDriverExceptionData"/> class.
        /// </summary>
        public WebDriverException()
            : base()
        {
        }

        public WebDriverException(WebDriverExceptionData webDriverExceptionData)
            : this(webDriverExceptionData.ErrorCode,webDriverExceptionData.Message)
        {
            this.ClassName = webDriverExceptionData.ClassName;
            this.Screenshot = webDriverExceptionData.Screenshot;
            this.SessionId = webDriverExceptionData.SessionId;
            this.ErrorCode = webDriverExceptionData.ErrorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDriverExceptionData"/> class with a
        /// specified error code and error message.
        /// </summary>
        /// <param name="errorCode">
        /// The web driver error code.
        /// </param>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public WebDriverException(WebDriverError errorCode, string message)
            : base(message)
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDriverExceptionData"/> class with a
        /// specified error code, an error message and a reference to the inner exception that is the cause
        /// of this exception.
        /// </summary>
        /// <param name="errorCode">
        /// The web driver error code.
        /// </param>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="inner">
        /// The exception that is the cause of the current exception, or
        /// <see langword="null"/> if no inner exception is specified.
        /// </param>
        public WebDriverException(WebDriverError errorCode, string message, Exception inner)
            : base(message, inner)
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets the <see cref="WebDriverError"/> error code that describes the error.
        /// </summary>
        public WebDriverError ErrorCode
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the Id of the session in which the error occurred.
        /// This parameter is optional.
        /// </summary>
        public Guid? SessionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a screenshot of the application at the time the error occured.
        /// This parameter is optional.
        /// </summary>
        public byte[] Screenshot
        {
            get;
            set;
        }

        public string ClassName
        {
            get;
            set;
        }
    }
}
