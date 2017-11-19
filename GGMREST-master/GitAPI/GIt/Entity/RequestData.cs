using Newtonsoft.Json;


namespace GitAPI.Git.Entity
{
    public class RequestData<T>
    {
        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "owner")]
        public T Owner { get; set; }
    }
}
