using OptcgExplorer.Core.Entities;
using OptcgExplorer.Infrastructure.Dtos;
using OptcgExplorer.UseCases.Interfaces;
using System.Net.Http.Json;

namespace OptcgExplorer.Infrastructure.Services
{
    public sealed class CardService : ICardService
    {
        private readonly HttpClient _httpClient;

        public CardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<Card>> GetAllSetCardsAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetFromJsonAsync<List<CardDto>>(
                "api/allSetCards/",
                cancellationToken);

            return response?
                .Select(x => new Card
                {
                    CardSetId = x.CardSetId,
                    CardName = x.CardName,
                    SetId = x.SetId,
                    SetName = x.SetName,
                    CardColor = x.CardColor,
                    CardType = x.CardType,
                    CardImage = x.CardImage,
                    Rarity = x.Rarity,
                    CardText = x.CardText
                })
                .ToList() ?? [];
        }

        public async Task<IReadOnlyCollection<Card>> GetCardsByDeckAsync(string deckId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetFromJsonAsync<List<CardDto>>(
                $"api/decks/{deckId}/",
                cancellationToken);

            return response?
                .Select(x => new Card
                {
                    CardSetId = x.CardSetId,
                    CardName = x.CardName,
                    SetId = x.SetId,
                    SetName = x.SetName,
                    CardColor = x.CardColor,
                    CardType = x.CardType,
                    CardImage = x.CardImage,
                    Rarity = x.Rarity,
                    CardText = x.CardText
                })
                .ToList() ?? [];
        }


        public async Task<IReadOnlyCollection<Card>> GetCardsBySetAsync(string setId, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetFromJsonAsync<List<CardDto>>(
                $"api/sets/{setId}/",
                cancellationToken);

            return response?
                .Select(x => new Card
                {
                    CardSetId = x.CardSetId,
                    CardName = x.CardName,
                    SetId = x.SetId,
                    SetName = x.SetName,
                    CardColor = x.CardColor,
                    CardType = x.CardType,
                    CardImage = x.CardImage,
                    Rarity = x.Rarity,
                    CardText = x.CardText
                })
                .ToList() ?? [];
        }
    }
}
