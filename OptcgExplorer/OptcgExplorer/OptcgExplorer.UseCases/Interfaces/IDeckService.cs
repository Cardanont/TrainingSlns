namespace OptcgExplorer.UseCases.Interfaces
{
    public interface IDeckService
    {
        Task<IReadOnlyCollection<Deck>> GetDecksAsync(
            CancellationToken cancellationToken = default);
    }
}
