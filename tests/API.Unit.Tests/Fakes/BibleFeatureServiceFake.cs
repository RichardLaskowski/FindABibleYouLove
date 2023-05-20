using Application.Services.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace API.Unit.Tests.Fakes;
internal class BibleFeatureServiceFake : IBibleFeatureService
{
    private readonly List<BibleFeatureContract> _bibleFeatureContracts;
    public BibleFeatureServiceFake(List<BibleFeatureContract> bibleFeatureContracts)
    {
        _bibleFeatureContracts = bibleFeatureContracts;
    }

    public async Task<string> CreateAsync(BibleFeatureContract bibleFeatureContract) => await Task.FromResult(bibleFeatureContract.Id);
    public Task DeleteAsync(string id) => throw new NotImplementedException();
    public Task UpdateAsync(string id, BibleFeatureContract contract) => throw new NotImplementedException();
    public Task<BibleFeatureContract> GetAsync(string id) => throw new NotImplementedException();
    public async Task<IEnumerable<BibleFeatureContract>> GetAllAsync() => await Task.Run(() => _bibleFeatureContracts);
}
