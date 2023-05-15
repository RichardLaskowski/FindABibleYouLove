using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureService<TType> : BaseService<TType, BibleFeatureEntity<TType>, BibleFeatureContract<TType>>, IBibleFeatureService<TType> where TType : class
{
    protected IBibleFeatureRepository<TType> Repository => (IBibleFeatureRepository<TType>)_repo;
    protected IBibleFeatureMapper<TType> Mapper => (IBibleFeatureMapper<TType>)_mapper;

    public BibleFeatureService(IBibleFeatureRepository<TType> repo, IBibleFeatureMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleFeatureContract<TType>> CreateAsync(BibleFeatureContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, BibleFeatureContract<TType> contract) => throw new NotImplementedException();
    public override Task<BibleFeatureContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFeatureContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}