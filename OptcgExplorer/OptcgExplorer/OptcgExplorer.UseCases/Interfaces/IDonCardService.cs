namespace OptcgExplorer.UseCases.Interfaces
{
    public interface IDonCardService
    {
        Task<IReadOnlyCollection<DonCard>> GetAllDonCardsAsync(
            CancellationToken cancellationToken = default);
    }
}