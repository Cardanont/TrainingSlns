using OptcgExplorer.Core.Entities;
using OptcgExplorer.Infrastructure.Dtos;
using OptcgExplorer.UseCases.Interfaces;
using System.Net.Http.Json;

namespace OptcgExplorer.Infrastructure.Services
{
    public sealed class DonCardService : IDonCardService
    {

        private readonly HttpClient _httpClient;

        public DonCardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IReadOnlyCollection<DonCard>> GetAllDonCardsAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetFromJsonAsync<List<DonCardDto>>(
                "api/allDonCards/",
                cancellationToken);

            return response?
                .Select(x => new DonCard
                {
                    InventoryPrice = x.InventoryPrice,
                    MarketPrice = x.MarketPrice,
                    CardName = x.CardName,
                    CardText = x.CardText,
                    Rarity = x.Rarity,
                    CardType = x.CardType,
                    DonId = x.DonId,
                    DateScraped = x.DateScraped,
                    CardImageId = x.CardImageId,
                    CardImage = x.CardImage,
                    OptcgDonName = x.OptcgDonName
                }).ToList() ?? [];
        }
    }
}
