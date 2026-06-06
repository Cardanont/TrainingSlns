using OptcgExplorer.Core.Entities;

namespace OptcgExplorer.UseCases.Features.Cards.GetAllSetCards
{
    public sealed class GetAllSetCardsResult
    {
        public IReadOnlyCollection<Card> Cards { get; init; } = [];
    }
}
