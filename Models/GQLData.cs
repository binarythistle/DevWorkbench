using System.Text.Json.Serialization;

namespace DevWorkBench.Models
{
    public class GQLData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("command")]
        public Command[] Commands { get; set; }
    }
}