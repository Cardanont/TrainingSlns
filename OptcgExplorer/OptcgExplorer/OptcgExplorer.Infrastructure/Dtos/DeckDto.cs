using System.Text.Json.Serialization;

namespace OptcgExplorer.Infrastructure.Dtos
{
    public sealed class DeckDto
    {
        [JsonPropertyName("structure_deck_id")]
        public string StructureDeckId { get; init; } = string.Empty;
        [JsonPropertyName("structure_deck_name")]
        public string StructureDeckName { get; init; } = string.Empty;
    }
}
