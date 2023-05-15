using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleTranslationService<TType> : BaseService<TType, BibleTranslationEntity<TType>, BibleTranslationContract<TType>>, IBibleTranslationService<TType> where TType : class
{
    protected IBibleTranslationRepository<TType> Repository => (IBibleTranslationRepository<TType>)_repo;
    protected IBibleTranslationMapper<TType> Mapper => (IBibleTranslationMapper<TType>)_mapper;

    public BibleTranslationService(IBibleTranslationRepository<TType> repo, IBibleTranslationMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleTranslationContract<TType>> CreateAsync(BibleTranslationContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, BibleTranslationContract<TType> contract) => throw new NotImplementedException();
    public override Task<BibleTranslationContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleTranslationContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}