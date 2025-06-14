using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_tamagotchi_cli
{
    internal class Mascote
    {
        [JsonProperty("abilities")]
        public List<Abilities> Abilities { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("weight")]
        public int Weight { get; set; }


        public override string ToString()
        {
            return "Nome Pokemon: " + Name + "\n" +
                   "Altura: " + Height + "\n" +
                   "Peso: " + Weight + "\n" +
                   "Habilidades: " + string.Join(", ", Abilities.Select(a => a.Ability.Name)) + "\n";
        }
    }
}
