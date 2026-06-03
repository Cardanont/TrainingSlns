using OptcgExplorer.UseCases.Interfaces;

namespace OptcgExplorer.UseCases.Features.Sets.GetSets
{
    public sealed class GetSetsHandler
    {
        private readonly ISetService _setService;

        public GetSetsHandler(ISetService setService)
        {
            _setService = setService;
        }

        public async Task<GetSetsResult> HandleAsync(GetSetsQuery query,
            CancellationToken cancellationToken = default)
        {
            var sets = await _setService.GetSetAsync(cancellationToken);

            return new GetSetsResult
            {
                Sets = sets
            };
        }
    }
}
