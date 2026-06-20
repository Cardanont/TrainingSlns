using OptcgExplorer.Core.Entities;
using OptcgExplorer.Infrastructure.Dtos;
using OptcgExplorer.UseCases.Interfaces;
using System.Net.Http.Json;

namespace OptcgExplorer.Infrastructure.Services
{
    public sealed class DeckService : IDeckService
    {

        private readonly HttpClient _httpClient;

        public DeckService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<Deck>> GetDecksAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetFromJsonAsync<List<DeckDto>>(
                "api/allDecks/",
                cancellationToken);

            return response?
                .Select(x => new Deck
                {
                    StructureDeckId = x.StructureDeckId,
                    StructureDeckName = x.StructureDeckName
                    
                })
                .ToList() ?? [];
        }
    }
}
