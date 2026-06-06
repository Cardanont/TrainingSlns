namespace OptcgExplorer.Core.Entities
{
    public sealed class Card
    {
        public string CardSetId { get; init; } = string.Empty;
        public string CardName { get; init; } = string.Empty;

        public string SetId { get; init; } = string.Empty;
        public string SetName { get; init; } = string.Empty;

        public string CardColor { get; init; } = string.Empty;
        public string CardType { get; init; } = string.Empty;

        public string CardImage { get; init; } = string.Empty;

        public string Rarity { get; init; } = string.Empty;

        public string? CardText { get; init; }
    }
}
