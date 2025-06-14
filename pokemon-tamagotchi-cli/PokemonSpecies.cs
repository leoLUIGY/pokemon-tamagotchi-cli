using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_tamagotchi_cli
{
    internal class PokemonSpecies
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<PokemonResult> Results { get; set; }
    }
}
