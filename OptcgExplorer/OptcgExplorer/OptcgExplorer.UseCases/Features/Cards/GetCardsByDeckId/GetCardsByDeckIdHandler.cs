using OptcgExplorer.UseCases.Interfaces;

namespace OptcgExplorer.UseCases.Features.Cards.GetCardsByDeckId
{
    public sealed class GetCardsByDeckIdHandler
    {

        public readonly ICardService _cardService;

        public GetCardsByDeckIdHandler(ICardService cardService)
        {
            _cardService = cardService;
        }

        public async Task<GetCardsByDeckIdResult> HandleAsync(GetCardsByDeckIdQuery query,
            CancellationToken cancellationToken = default)
        {
            var cards = await _cardService.GetCardsByDeckAsync(query.DeckId, cancellationToken);

            return new GetCardsByDeckIdResult
            {
                Cards = cards
            };
        }
    }
}
