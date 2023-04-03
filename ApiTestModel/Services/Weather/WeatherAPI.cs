using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Services.Weather
{
    public class WeatherAPI
    {
        private HttpClient _restClient = new HttpClient();
        private string URI = "https://api.weather.gov/alerts?area=MN&severity=severe";
        public async Task<string> Get_ReasonPhrase()
        {
            //BUILD URI
            _restClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml,application/xml");
            _restClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");
            _restClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
            _restClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");
        
            //GET CALL
            var response = await _restClient.GetAsync(URI);

            //Read the ReasonPhrase
            var reasonPhrase = response.ReasonPhrase.ToString();
            return reasonPhrase;
        }
    }
}
 
