using System;
using System.Collections.Generic;

namespace RyMApi.Models
{
    /// Representa un personaje de la API de Rick and Morty.
    /// Contiene información básica, origen, ubicación, episodios y metadatos.
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public Origin origin { get; set; }
        public Location location { get; set; }
        public string image { get; set; }
        public List<string> episode { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
    }

    /// Representa el origen de un personaje en la API de Rick and Morty.
    public class Origin
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    /// Representa la ubicación de un personaje en la API de Rick and Morty.
    public class Location
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
