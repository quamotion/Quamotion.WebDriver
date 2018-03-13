using System.Linq;
using Xunit;

namespace Quamotion.WebDriver.Client.Tests
{
    public class AppDriverTests
    {
        [Fact]
        public void Test1()
        {
            var device = WebDriverExtensions.Devices.SingleOrDefault();

            AppDriver driver = new AppDriver(new DeviceCapabilities(deviceId: device.UniqueId));
            var source = driver.PageSource;
        }
    }
}
