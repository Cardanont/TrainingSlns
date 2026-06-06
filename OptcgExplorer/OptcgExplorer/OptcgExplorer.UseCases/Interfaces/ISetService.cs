using OptcgExplorer.Core.Entities;

namespace OptcgExplorer.UseCases.Interfaces
{
    public interface ISetService
    {
        Task<IReadOnlyCollection<Set>> GetSetsAsync(
            CancellationToken cancellationToken = default);

        
    }
}
