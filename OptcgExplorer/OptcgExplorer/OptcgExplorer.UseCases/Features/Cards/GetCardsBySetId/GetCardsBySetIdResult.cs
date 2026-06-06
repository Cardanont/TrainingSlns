using OptcgExplorer.Core.Entities;

namespace OptcgExplorer.UseCases.Features.Cards.GetCardsBySetId
{
    public sealed class GetCardsBySetIdResult
    {
        public IReadOnlyCollection<Card> Cards { get; init; } = [];
    }
}
