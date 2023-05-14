using Domain.Common.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleTranslationRepository<TType> : IRepository<TType, BibleTranslationEntity<TType>> where TType : class
{

}