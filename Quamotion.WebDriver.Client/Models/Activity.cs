using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents activity data measured by the Energy Log.
    /// </summary>
    public struct Activity
    {
        /// <summary>
        /// Gets the size of an activity, in binary format.
        /// </summary>
        public const int Size = 0x28;

        /// <summary>
        /// Gets or sets the duration of the sampling period.
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets or sets an unknown value.
        /// </summary>
        public double Unknown { get; set; }

        /// <summary>
        /// Gets or sets the amount of CPU consumed by the foreground app.
        /// </summary>
        public double ForegroundApp { get; set; }

        /// <summary>
        /// Gets or sets the amount of CPU consumed by graphics components.
        /// </summary>
        public double Graphics { get; set; }

        /// <summary>
        /// Gets or sets the amount of CPU consumed by media components.
        /// </summary>
        public double Media { get; set; }

    }
}
