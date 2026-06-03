using OptcgExplorer.Core.Entities;

namespace OptcgExplorer.UseCases.Interfaces
{
    public interface ISetService
    {
        Task<IReadOnlyCollection<Set>> GetSetAsync(
            CancellationToken cancellationToken = default);
    }
}
