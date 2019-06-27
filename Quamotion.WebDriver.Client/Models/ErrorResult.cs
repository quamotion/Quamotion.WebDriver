using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    public class ErrorResult
    {
        /// <summary>
        /// Gets or sets an <see cref="Exception"/> that describes the error.
        /// </summary>
        public Exception Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the screenshot as a byte array.
        /// </summary>
        public byte[] Screenshot
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an implementation-defined string with a human readable description of the kind of error that occurred
        /// </summary>
        public string ErrorMessage
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the ID of the session in which the error occurred.
        /// </summary>
        public Guid? SessionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="WebDriverError"/> value which describes the error.
        /// </summary>
        public WebDriverError Status
        {
            get;
            set;
        }
    }
}
