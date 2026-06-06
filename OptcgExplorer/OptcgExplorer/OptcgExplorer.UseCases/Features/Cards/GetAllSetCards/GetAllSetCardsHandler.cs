using OptcgExplorer.UseCases.Interfaces;

namespace OptcgExplorer.UseCases.Features.Cards.GetAllSetCards
{
    public sealed class GetAllSetCardsHandler
    {
        private readonly ICardService _cardService;

        public GetAllSetCardsHandler(ICardService cardService)
        {
            _cardService = cardService;
        }
        
        public async Task<GetAllSetCardsResult> HandleAsync(GetAllSetCardsQuery query,
            CancellationToken cancellationToken = default)
        {
            var cards = await _cardService.GetAllSetCardsAsync(cancellationToken);

            return new GetAllSetCardsResult
            {
                Cards = cards
            };
        }

    }
}
