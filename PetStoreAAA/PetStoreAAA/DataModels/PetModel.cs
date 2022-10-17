using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreAAA.DataModels
{
    public class PetModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("category")]
        public CategoryModel Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photoUrls")]
        public string[] PhotoUrls { get; set; }

        [JsonProperty("tags")]
        public List<TagsModel> Tags { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
