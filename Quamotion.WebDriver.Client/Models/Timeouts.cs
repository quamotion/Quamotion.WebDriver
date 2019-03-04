using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Provides access to the time-out values used by the Quamotion WebDriver.
    /// </summary>
    public class Timeouts
    {
        /// <summary>
        /// Gets or sets a time to wait for scripts to run.
        /// </summary>
        [JsonProperty("scriptTimeout")]
        public TimeSpan ScriptTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the session page load timeout.
        /// </summary>
        /// <remarks>
        /// Specifies a time to wait for the page loading to complete.
        /// </remarks>
        [JsonProperty("pageLoadTimeout")]
        public TimeSpan PageLoadTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the session implicit wait timeout.
        /// </summary>
        /// <remarks>
        /// Specifies a time to wait for the implicit element location strategy when locating elements using Find Element and Find Elements.
        /// </remarks>
        [JsonProperty("implicitWaitTimeout")]
        public TimeSpan ImplicitWaitTimeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount of time to wait for a screenshot to complete.
        /// </summary>
        [JsonProperty("screenshotTimeout")]
        public TimeSpan ScreenshotTimeout
        {
            get;
            set;
        }
    }
}
