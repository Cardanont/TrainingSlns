using System.Text.Json.Serialization;

namespace OptcgExplorer.Infrastructure.Dtos
{
    public sealed class SetDto
    {
        [JsonPropertyName("set_id")]
        public string SetId { get; set; } = string.Empty;

        [JsonPropertyName("set_name")]
        public string SetName { get; set; } = string.Empty;
    }
}
