using Newtonsoft.Json;
using Quamotion.WebDriver.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    public class EnergyClient: TracingClient
    {

        public double PowerState { get; private set; }

        public double Level { get; private set; }

        public EnergyDeviceState Bluetooth { get; private set; }

        public EnergyDeviceState Gps { get; private set; }

        public EnergyDeviceState Wifi { get; private set; }

        public string PowerSourceEvents { get; private set; }

        public double Brightness { get; private set; }

        public NetworkActivity NetworkActivity { get; private set; }

        public Activity Activity { get; private set; }

        private string DeviceId { get; }

        public EnergyClient(string deviceId)
        {
            this.DeviceId = deviceId;
        }

        protected override string Url
        {
            get
            {
                return $"http://localhost:17894/wd/hub/quamotion/device/{this.DeviceId}/energy";
            }
        }

        protected override void HandleEvent(string data)
        {
            if(string.IsNullOrEmpty(data))
            {
                return;
            }

            var powerMeasurementType = JsonConvert.DeserializeObject<Data<PowerMeasurement<object>>>($"{{{data}}}").Value.Type;

            switch (powerMeasurementType)
            {
                case PowerMeasurementType.Activity:
                    this.Activity = JsonConvert.DeserializeObject<Data<PowerMeasurement<Activity>>>($"{{{data}}}").Value.Payload;
                    break;
                case PowerMeasurementType.Bluetooth:
                    this.Bluetooth = JsonConvert.DeserializeObject<Data<PowerMeasurement<EnergyDeviceState>>>($"{{{data}}}").Value.Payload;
                    break;
                case PowerMeasurementType.Brightness:
                    this.Brightness = JsonConvert.DeserializeObject<Data<PowerMeasurement<double>>>($"{{{data}}}").Value.Payload;
                    break;
                case PowerMeasurementType.Gps:
                    this.Gps = JsonConvert.DeserializeObject<Data<PowerMeasurement<EnergyDeviceState>>>($"{{{data}}}").Value.Payload;
                    break;
                case PowerMeasurementType.Level:
                    this.Level = JsonConvert.DeserializeObject<Data<PowerMeasurement<double>>>($"{{{data}}}").Value.Payload;
                    break;
                case PowerMeasurementType.NetworkActivity:
                    this.NetworkActivity = JsonConvert.DeserializeObject<Data<PowerMeasurement<NetworkActivity>>>($"{{{data}}}").Value.Payload;
                    break;
                case PowerMeasurementType.PowerSourceEvents:
                    this.PowerSourceEvents = JsonConvert.DeserializeObject<Data<PowerMeasurement<string>>>($"{{{data}}}").Value.Payload;
                    break;
                case PowerMeasurementType.PowerState:
                    this.PowerState = JsonConvert.DeserializeObject<Data<PowerMeasurement<double>>>($"{{{data}}}").Value.Payload;
                    break;
                case PowerMeasurementType.Wifi:
                    this.Wifi = JsonConvert.DeserializeObject<Data<PowerMeasurement<EnergyDeviceState>>>($"{{{data}}}").Value.Payload;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
