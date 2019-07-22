using Microsoft.VisualStudio.Threading;
using Newtonsoft.Json;
using Quamotion.WebDriver.Client.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    public class DeviceStatisticClient: TracingClient
    {
        public DeviceStatistic DeviceStatistic { get; private set; }

        private string DeviceId { get; }

        public DeviceStatisticClient(string deviceId)
        {
            this.DeviceId = deviceId;
        }

        protected override string Url
        {
            get
            {
                return $"http://localhost:17894/wd/hub/quamotion/device/{this.DeviceId}/stats";
            }
        }

        protected override void HandleEvent(string data)
        {
            var deviceStatistic = JsonConvert.DeserializeObject<Data<DeviceStatistic>>($"{{{data}}}");
            this.DeviceStatistic = deviceStatistic.Value;
        }
    }
}
