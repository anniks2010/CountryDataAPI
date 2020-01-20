using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace CountryDataAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://restcountries.eu/rest/v2/name/eesti";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd(); ////panen valmis koha, kuhu maha lugeda, mis on olemas vastuses
                var countrydata = JsonConvert.DeserializeObject<List<CountryDetails>>(response);
                ///var name = countrydata[0].Name;
                Console.WriteLine($"Name: {countrydata[0].Name}");
                Console.WriteLine($"Cioc: {countrydata[0].Cioc}");
                Console.WriteLine($"Domain: {countrydata[0].TopLevelDomain[0]}");
                Console.WriteLine($"Capital: {countrydata[0].Capital}");
                Console.WriteLine($"Region: {countrydata[0].Region}");
                Console.WriteLine($"Population: {countrydata[0].Population}");
                Console.WriteLine($"Language:{countrydata[0].Languages[0].Name}");

            }
        }
    }
    
}
