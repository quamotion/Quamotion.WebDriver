using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    public class WebDriverResponse<T>
    {
        /// <summary>
        /// Gets or sets an opaque handle used by the server to determine where to route session-specific commands.
        /// This ID should be included in all future session-commands in place of the :sessionId path segment variable.
        /// </summary>
        [JsonProperty("sessionId")]
        public Guid? SessionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or setse a status code summarizing the result of the command. A non-zero value indicates that the command failed.
        /// </summary>
        [JsonProperty("status")]
        public WebDriverError Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the response JSON value.
        /// </summary>
        [JsonProperty("value")]
        public T Value
        {
            get;
            set;
        }
    }
}
