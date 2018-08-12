namespace WebAPI4AngularCosmosDB.Models
{
    using Newtonsoft.Json;
    public class Hero
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "uid")]
        public string UId { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "saying")]
        public string Saying { get; set; }
    }
}
