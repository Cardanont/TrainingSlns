namespace OptcgExplorer.UseCases.Interfaces
{
    public interface IDonCardService
    {
        Task<IReadOnlyCollection<DonCard>> GetDonCardsAsync(
            CancellationToken cancellationToken = default);
    }
}