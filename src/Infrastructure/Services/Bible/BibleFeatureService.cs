using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureService: BaseService<string, BibleFeatureEntity<string>, BibleFeatureContract<string>>, IBibleFeatureService<string> 
{
    protected IBibleFeatureRepository<string> BibleFeatureRepo => (IBibleFeatureRepository<string>)_repo;
    protected IBibleFeatureMapper<string> BibleFeatureMapper => (IBibleFeatureMapper<string>)_mapper;

    public BibleFeatureService(IBibleFeatureRepository<string> repo, IBibleFeatureMapper<string> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleFeatureContract<string>> CreateAsync(BibleFeatureContract<string> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleFeatureContract<string> contract) => throw new NotImplementedException();
    public override Task<BibleFeatureContract<string>> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleFeatureContract<string>>> GetAllAsync() => await BibleFeatureMapper.MapAllAsync(await BibleFeatureRepo.GetAllAsync());
}