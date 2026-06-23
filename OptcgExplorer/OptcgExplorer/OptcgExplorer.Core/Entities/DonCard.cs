namespace OptcgExplorer.Core.Entities
{
    public sealed class DonCard
    {
        public decimal InventoryPrice { get; init; }
        public decimal MarketPrice { get; init; }

        public string CardName { get; init; } = string.Empty;
        public string? CardText { get; init; }

        public string Rarity { get; init; } = string.Empty;
        public string CardType { get; init; } = string.Empty;

        public string? DonId { get; init; }

        public string? DateScraped { get; init; }

        public string? CardImageId { get; init; }
        public string? CardImage { get; init; }

        public string? OptcgDonName { get; init; }
    }
}
