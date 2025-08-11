using Newtonsoft.Json;
using RyMApi.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RyMApi.Controlles
{
    public class CharacterControlles
    {
        private readonly HttpClient client;

        public CharacterControlles()
        {
            client = new HttpClient();
        }

        public async Task<Characters> GetAllCharacters()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://rickandmortyapi.com/api/character");
                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Characters>(responseJson);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
