using System.Collections.Generic;

namespace RyMApi.Models
{
    /// Representa una colección de personajes obtenidos de la API de Rick and Morty.
    public class Characters
    {
        public List<Character> results { get; set; }
    }
}
