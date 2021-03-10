using System.Text.Json.Serialization;

namespace DevWorkBench.Models
{
     public class Command
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("howTo")]
        public string HowTo { get; set; }

        [JsonPropertyName("commandLine")]
        public string CommandLine { get; set; }

        [JsonPropertyName("platform")]
        public Platform Platform { get; set; }
    }
}