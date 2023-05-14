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
}