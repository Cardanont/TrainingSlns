using System.Text.Json.Serialization;

namespace OptcgExplorer.Infrastructure.Dtos
{
    public sealed class CardDto
    {
        [JsonPropertyName("card_set_id")]
        public string CardSetId { get; set; } = string.Empty;
        [JsonPropertyName("card_name")]
        public string CardName { get; set; } = string.Empty;

        [JsonPropertyName("set_id")]
        public string SetId { get; set; } = string.Empty;
        [JsonPropertyName("set_name")]
        public string SetName { get; set; } = string.Empty;

        [JsonPropertyName("card_color")]
        public string CardColor { get; set; } = string.Empty;
        [JsonPropertyName("card_type")]
        public string CardType { get; set; } = string.Empty;

        [JsonPropertyName("card_image")]
        public string CardImage { get; set; } = string.Empty;

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; } = string.Empty;


        public string? CardText { get; set; }
    }
}
