using Newtonsoft.Json;

namespace GroceryServices.Types
{
    /// <summary>
    /// { "id": "1", "category": "Grocery", "name": "wheat", "description": "for roti", "quantity":"1","specification":"kg","isComplete": false }
    /// </summary>
    public class Grocery
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public string Quantity { get; set; }

        [JsonProperty(PropertyName = "specification")]
        public string Specification { get; set; }

        [JsonProperty(PropertyName = "isComplete")]
        public bool IsComplete { get; set; }
    }
}
