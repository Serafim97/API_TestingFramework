using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Weather;
namespace TestProject.WeatherAPI
{
    public class WeatherAPI_Tests
    {
        [Test]
        [Category("APITests")]
        public async Task API_Test()
        {
            Services.Weather.WeatherAPI weatherAPI = new Services.Weather.WeatherAPI();
            var reasonPhrase = await weatherAPI.Get_ReasonPhrase();
            Assert.AreEqual("OK", reasonPhrase);
        }
    }
}
