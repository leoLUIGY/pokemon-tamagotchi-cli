using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_tamagotchi_cli
{
    internal class Ability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
