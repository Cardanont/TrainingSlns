

namespace OptcgExplorer.UseCases.Features.Decks
{
    public sealed class GetDecksResult
    {
        public IReadOnlyCollection<Deck> Decks { get; init; } = [];
    }
}
