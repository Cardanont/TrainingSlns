namespace OptcgExplorer.UseCases.Features.Dons.GetAllDonCards
{
    public sealed class GetAllDonCardsResult
    {
        public IReadOnlyCollection<DonCard> DonCards { get; set; } = [];
    }
}
