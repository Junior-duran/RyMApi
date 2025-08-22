using Newtonsoft.Json;
using RyMApi.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RyMApi.Controlles
{
    /// Controlador encargado de consumir la API de Rick and Morty.
    /// - Maneja las peticiones HTTP.
    /// - Deserializa la respuesta JSON en objetos C#.
    public class CharacterControlles
    {
        // Cliente HTTP para realizar las peticiones a la API
        private readonly HttpClient client;
        /// Constructor: inicializa el cliente HTTP.
        public CharacterControlles()
        {
            client = new HttpClient();
        }
        /// Método asincrónico que obtiene todos los personajes desde la API.
        /// - Usa HttpClient para hacer la petición GET.
        /// - Convierte la respuesta en un string JSON.
        /// - Usa JsonConvert para deserializar el JSON en la clase Characters.
        ///  Un objeto Characters con la lista de resultados, o null si falla la petición.
        public async Task<Characters> GetAllCharacters()
        {
            try
            {
                // Petición GET a la API
                HttpResponseMessage response = await client.GetAsync("https://rickandmortyapi.com/api/character");
                response.EnsureSuccessStatusCode();
                
                // Leer el contenido de la respuesta como string
                string responseJson = await response.Content.ReadAsStringAsync();
                // Deserializar el JSON a un objeto Characters
                return JsonConvert.DeserializeObject<Characters>(responseJson);

            }
            catch (Exception)
            {
                // Si ocurre un error, se captura la excepción y se retorna null
                return null;
            }
        }
    }
}
