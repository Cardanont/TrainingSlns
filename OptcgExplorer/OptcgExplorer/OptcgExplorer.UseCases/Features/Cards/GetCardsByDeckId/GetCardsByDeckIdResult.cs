namespace OptcgExplorer.UseCases.Features.Cards.GetCardsByDeckId
{
    public sealed class GetCardsByDeckIdResult
    {
        public IReadOnlyCollection<Card> Cards{ get; init; } = [];
    }
}
