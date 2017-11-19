using Newtonsoft.Json;


namespace GitAPI.Git.Entity
{
    public class OwnerData
    {
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
