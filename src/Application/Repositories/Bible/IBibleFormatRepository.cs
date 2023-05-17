using Domain.Base.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleFormatRepository<TType> : IBaseRepository<TType, BibleFormatEntity<TType>> where TType : class
{

}