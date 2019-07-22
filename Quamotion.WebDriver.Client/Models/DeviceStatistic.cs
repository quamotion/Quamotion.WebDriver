// <copyright file="DeviceStatistic.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents performance data of a device.
    /// </summary>
    public class DeviceStatistic
    {
        /// <summary>
        /// Gets or sets the time at which the performance data was captured.
        /// </summary>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets a value which represents the total CPU usage.
        /// </summary>
        public double? CpuUsage { get; set; }

        /// <summary>
        /// Gets or sets a value which represents the total memory usage (in bytes).
        /// </summary>
        public long? MemoryUsage { get; set; }
    }
}
