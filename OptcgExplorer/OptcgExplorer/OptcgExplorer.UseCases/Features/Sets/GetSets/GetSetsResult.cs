using OptcgExplorer.Core.Entities;

namespace OptcgExplorer.UseCases.Features.Sets.GetSets
{
    public sealed class GetSetsResult
    {
        public IReadOnlyCollection<Set> Sets { get; init; } = [];
    }
}
