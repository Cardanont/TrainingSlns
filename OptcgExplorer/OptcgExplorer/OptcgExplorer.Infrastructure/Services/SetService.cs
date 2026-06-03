using OptcgExplorer.Core.Entities;
using OptcgExplorer.Infrastructure.Dtos;
using OptcgExplorer.UseCases.Interfaces;
using System.Net.Http.Json;

namespace OptcgExplorer.Infrastructure.Services
{
    public sealed class SetService : ISetService
    {
        private readonly HttpClient _httpClient;

        public SetService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<Set>> GetSetAsync(CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetFromJsonAsync<List<SetDto>>(
                "api/allSets/",
                cancellationToken);

            return response?
                .Select(x => new Set
                {
                    SetId = x.SetId,
                    SetName = x.SetName
                })
                .ToList() ?? [];
        }
    }
}
