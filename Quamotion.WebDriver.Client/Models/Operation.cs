using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    public class Operation
    {
        /// <summary>
        /// Gets or sets the operation to execute.
        /// </summary>
        [JsonProperty("operation")]
        public string OperationName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the operation arguments.
        /// </summary>
        [JsonProperty("args")]
        public Collection<object> Arguments
        {
            get;
            set;
        }
    }
}
