using Domain.Base.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleTranslationRepository<TType> : IBaseRepository<TType, BibleTranslationEntity<TType>> where TType : class
{

}