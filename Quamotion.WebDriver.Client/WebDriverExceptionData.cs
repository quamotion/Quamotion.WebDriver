using Newtonsoft.Json;
using Quamotion.WebDriver.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// The data corresponding to the exception that is thrown when a WebDriver-related error occurs.
    /// </summary>
    public class WebDriverExceptionData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDriverExceptionData"/> class.
        /// </summary>
        public WebDriverExceptionData()
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="WebDriverError"/> error code that describes the error.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public WebDriverError ErrorCode
        {
            get;
            set;
        }

        /// <summary>
        /// Get or sets the message of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Id of the session in which the error occurred.
        /// This parameter is optional.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public Guid? SessionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a screenshot of the application at the time the error occured.
        /// This parameter is optional.
        /// </summary>
        [JsonProperty(PropertyName = "screenshot")]
        public byte[] Screenshot
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "className")]
        public string ClassName
        {
            get;
            set;
        }
    }
}
