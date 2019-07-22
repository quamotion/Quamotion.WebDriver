using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    public enum EnergyDeviceState
    {

        /// <summary>
        /// The state of the device is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// The device is active.
        /// </summary>
        On,

        /// <summary>
        /// The device is off.
        /// </summary>
        Off
    }
}
