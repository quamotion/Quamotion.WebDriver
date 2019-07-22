using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Summarizes the network activity of a device.
    /// </summary>
    public class NetworkActivity
    {
        /// <summary>
        /// Gets the size, in bytes, of a network activity struct on the wire.
        /// </summary>
        public const int Size = 0xC8;

        /// <summary>
        /// Gets or sets the amount of time during which the trace was captured.
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets or sets the amount of packets received over the WiFi connection.
        /// </summary>
        public double WifiPacketsIn { get; set; }

        /// <summary>
        /// Gets or sets the amount of packets sent over the WiFi connection.
        /// </summary>
        public double WifiPacketsOut { get; set; }

        /// <summary>
        /// Gets or sets the amount of bytes received over the WiFi connection.
        /// </summary>
        public double WifiBytesIn { get; set; }

        /// <summary>
        /// Gets or sets the amount of bytes sent over the WiFi connection.
        /// </summary>
        public double WifiBytesOut { get; set; }

        /// <summary>
        /// Gets or sets the number of receive errors over the WiFi connection.
        /// </summary>
        public double WifiReceiveErrors { get; set; }

        /// <summary>
        /// Gets or sets the number of transmit errors over the WiFi connection.
        /// </summary>
        public double WifiSendErrors { get; set; }

        /// <summary>
        /// Gets or sets the amount of packets received over the cellular connection.
        /// </summary>
        public double CellularPacketsIn { get; set; }

        /// <summary>
        /// Gets or sets the amount of packets sent over the cellular connection.
        /// </summary>
        public double CellularPacketsOut { get; set; }

        /// <summary>
        /// Gets or sets the amount of bytes received over the cellular connection.
        /// </summary>
        public double CellularBytesIn { get; set; }

        /// <summary>
        /// Gets or sets the amount of bytes sent over the cellular connection.
        /// </summary>
        public double CellularBytesOut { get; set; }

        /// <summary>
        /// Gets or sets the number of receive errors over the cellular connection.
        /// </summary>
        public double CellularReceiveErrors { get; set; }

        /// <summary>
        /// Gets or sets the number of transmit errors over the cellular connection.
        /// </summary>
        public double CellularSendErrors { get; set; }
    }
}
