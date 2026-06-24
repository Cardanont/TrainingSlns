using OptcgExplorer.UseCases.Interfaces;

namespace OptcgExplorer.UseCases.Features.Dons.GetAllDonCards
{
    public sealed class GetAllDonCardsHandler
    {

        private readonly IDonCardService _donCardService;

        public GetAllDonCardsHandler(IDonCardService donCardService)
        {
            _donCardService = donCardService;
        }

        public async Task<GetAllDonCardsResult> HandleAsync(GetAllDonCardsQuery query,
            CancellationToken cancellationToken = default)
        {
            var donCards = await _donCardService.GetAllDonCardsAsync(cancellationToken);

            return new GetAllDonCardsResult
            {
                DonCards = donCards
            };
        }

    }
}
