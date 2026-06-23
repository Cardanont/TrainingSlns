using OptcgExplorer.UseCases.Interfaces;

namespace OptcgExplorer.UseCases.Features.Decks.GetDecks
{
    public sealed class GetDecksHandler
    {

        private readonly IDeckService _deckService;

        public GetDecksHandler(IDeckService deckService)
        {
            _deckService = deckService;
        }

        public async Task<GetDecksResult> HandleAsync(GetDecksQuery query,
            CancellationToken cancellationToken = default)
        {
            var decks = await _deckService.GetDecksAsync(cancellationToken);

            return new GetDecksResult
            {
                Decks = decks
            };
        }

    }
}
    