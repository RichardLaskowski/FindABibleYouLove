using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Base.Classes.Services;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureService: StringBaseService<BibleFeatureContract, BibleFeatureEntity>, IBibleFeatureService 
{
    protected IBibleFeatureRepository BibleFeatureRepository => (IBibleFeatureRepository)_repo;
    protected IBibleFeatureMapper BibleFeatureMapper => (IBibleFeatureMapper)_mapper;

    public BibleFeatureService(IBibleFeatureRepository repo, IBibleFeatureMapper mapper) : base(repo, mapper)
    {

    }

    public override async Task<string> CreateAsync(BibleFeatureContract contract)
    {
        BibleFeatureEntity bibleFeatureEntity = await BibleFeatureMapper.MapAsync(contract);
        string bibleFeatureId = BibleFeatureRepository.Add(bibleFeatureEntity);

        return bibleFeatureId;
    }

    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleFeatureContract contract) => throw new NotImplementedException();
    public override Task<BibleFeatureContract> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleFeatureContract>> GetAllAsync()
    {
        return await BibleFeatureMapper.MapAllAsync(await BibleFeatureRepository.GetAllAsync());
    }
}