using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents a power measurement.
    /// </summary>
    public class PowerMeasurement<T>
    {
        /// <summary>
        /// Gets or sets the measurement data.
        /// </summary>
        public T Payload { get; set; }

        /// <summary>
        /// Gets or sets the type of data being measured.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PowerMeasurementType Type { get; set; }

        /// <summary>
        /// Gets or sets the date and time at which the event occurred.
        /// </summary>
        public DateTimeOffset AbsoluteTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the measurement was captured. This value is relative
        /// to the start of the trace.
        /// </summary>
        public TimeSpan Timestamp { get; set; }
    }
}
