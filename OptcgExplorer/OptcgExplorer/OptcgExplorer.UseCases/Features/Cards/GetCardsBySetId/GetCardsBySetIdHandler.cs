using OptcgExplorer.UseCases.Interfaces;

namespace OptcgExplorer.UseCases.Features.Cards.GetCardsBySetId
{
    public sealed class GetCardsBySetIdHandler
    {
        private readonly ICardService _cardService;

        public GetCardsBySetIdHandler(ICardService cardService)
        {
            _cardService = cardService;
        }

        public async Task<GetCardsBySetIdResult> HandleAsync(GetCardsBySetIdQuery query,
            CancellationToken cancellationToken = default)
        {
            var cards = await _cardService.GetCardsBySetAsync(query.SetId, cancellationToken);

            return new GetCardsBySetIdResult
            {
                Cards = cards
            };
        }
    }
}
