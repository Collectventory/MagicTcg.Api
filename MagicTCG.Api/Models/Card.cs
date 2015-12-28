using System.Collections.Generic;
using Newtonsoft.Json;

namespace MagicTcg.Api.Models
{
    public class Card
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("cmc")]
        public int? ConvertedManaCost { get; set; }

        [JsonProperty("colors")]
        public List<string> Colors { get; set; }

        [JsonProperty("floavor")]
        public string FlavorText { get; set; }

        [JsonProperty("legalities")]
        public Dictionary<string, string> Legalities { get; set; }

        [JsonProperty("manaCost")]
        public string ManaCost { get; set; }

        [JsonProperty("multiverseid")]
        public string MultiverseID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("subtypes")]
        public List<string> Subtypes { get; set; }

        [JsonProperty("text")]
        public List<string> Text { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("types")]
        public List<string> Types { get; set; }
    }
}
