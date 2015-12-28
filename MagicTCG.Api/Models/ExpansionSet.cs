using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MagicTcg.Api.Models
{
    public class ExpansionSet
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }
    }
}
