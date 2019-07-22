using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Determines the type of a power measurement.
    /// </summary>
    public enum PowerMeasurementType
    {
        /// <summary>
        /// A power state measurement has a <see cref="double"/> value, which represents the power state of a device.
        /// Value 4 means the device is connected to a power source.
        /// </summary>
        PowerState,

        /// <summary>
        /// A power level measurement as a <see cref="double"/> value, which represents the total power consumption
        /// of the device.
        /// </summary>
        Level,

        /// <summary>
        /// A Bluetooth measurement has a <see cref="EnergyDeviceState"/> value, which indicates whether Bluetooth is enabled
        /// or not.
        /// </summary>
        Bluetooth,

        /// <summary>
        /// A NetworkActivity measurement has a <see cref="NetworkActivity"/> value, which represents the network activity
        /// of the device.
        /// </summary>
        NetworkActivity,

        /// <summary>
        /// A GPS measurement has a <see cref="EnergyDeviceState"/> value, which indicates whether GPS is enabled
        /// or not.
        /// </summary>
        Gps,

        /// <summary>
        /// A Activity measurement has a <see cref="Activity"/> value, which represents CPU usage of different
        /// components of the device.
        /// </summary>
        Activity,

        /// <summary>
        /// A <see cref="PowerSourceEvents"/> measurement has a <see cref="string"/> value, and contains various diagnostic
        /// messages which describe the power source.
        /// </summary>
        PowerSourceEvents,

        /// <summary>
        /// A Wifi measurement has a <see cref="EnergyDeviceState"/> value, which indicates whether WiFi is enabled
        /// or not.
        /// </summary>
        Wifi,

        /// <summary>
        /// A brightness measurement has a <see cref="double"/> value, which represents the brightness of the display.
        /// </summary>
        Brightness
    }
}
