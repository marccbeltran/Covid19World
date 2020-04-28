
using covid19World.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace covid19World.Services
{
    public class ApiCountryData
    {
        private const string apiUrl = "https://corona.lmao.ninja/v2/countries?yesterday=false&sort=cases";

        public async Task<List<TotalCases>> BasicCallAsync()
        {

            using var client = new HttpClient();
            string content = await client.GetStringAsync(apiUrl);

            return JsonConvert.DeserializeObject <List<TotalCases>>(content);
        }

    }
}
