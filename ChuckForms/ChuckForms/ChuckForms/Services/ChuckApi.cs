using ChuckForms.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChuckForms.Services
{
    public class ChuckApi
    {
        readonly string _api_base_url = "https://api.chucknorris.io/jokes";

        public async Task<List<string>> GetAllCategoriesAsync()
        {
            using (var client = new HttpClient())
            {
                //grab json from server
                var json = await GetJsonData($"{_api_base_url}/categories");

                //Deserialize json
                var items = JsonConvert.DeserializeObject<List<string>>(json);

                //return the items
                return items;
            }
        }
        public async Task<Joke> GetRandomJokeByCategoyAsync(string category)
        {
            //grab json from server
            var json = await GetJsonData($"{_api_base_url}/random?category={category}");

            //Deserialize json
            var joke = JsonConvert.DeserializeObject<Joke>(json);

            //return the items
            return joke;
        }
        async Task<string> GetJsonData(string url)
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(url);
                return json;
            }
        }
    }
}
