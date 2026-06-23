namespace OptcgExplorer.UseCases.Features.Decks.GetDecks
{
    public sealed class GetDecksResult
    {
        public IReadOnlyCollection<Deck> Decks { get; init; } = [];
    }
}
