using System.Text.Json.Serialization;

namespace OptcgExplorer.Infrastructure.Dtos

{
    public sealed class DonCardDto
    {
        [JsonPropertyName("inventory_price")]
        public decimal InventoryPrice { get; set; }

        [JsonPropertyName("market_price")]
        public decimal MarketPrice { get; set; }

        [JsonPropertyName("card_name")]
        public string CardName { get; set; } = string.Empty;

        [JsonPropertyName("card_text")]
        public string CardText { get; set; } = string.Empty;

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; } = string.Empty;

        [JsonPropertyName("card_type")]
        public string CardType { get; set; } = string.Empty;

        [JsonPropertyName("don_id")]
        public string DonId { get; set; } = string.Empty;

        [JsonPropertyName("date_scraped")]
        public string DateScraped { get; set; } = string.Empty;

        [JsonPropertyName("card_image_id")]
        public string CardImageId { get; set; } = string.Empty;

        [JsonPropertyName("card_image")]
        public string CardImage { get; set; } = string.Empty;

        [JsonPropertyName("optcg_don_name")]
        public string OptcgDonName { get; set; } = string.Empty;
    }
}
