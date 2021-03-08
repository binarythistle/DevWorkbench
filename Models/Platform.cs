using System.Text.Json.Serialization;

namespace DevWorkBench.Models
{
    public class Platform
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}