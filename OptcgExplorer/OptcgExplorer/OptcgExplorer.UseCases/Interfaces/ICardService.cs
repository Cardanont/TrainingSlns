using OptcgExplorer.Core.Entities;

namespace OptcgExplorer.UseCases.Interfaces
{
    public  interface ICardService
    {
        Task<IReadOnlyCollection<Card>> GetAllSetCardsAsync(
            CancellationToken cancellationToken = default);

        Task<IReadOnlyCollection<Card>>
            GetCardsBySetAsync(string setId,
            CancellationToken cancellationToken = default);
    }
}
