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
}