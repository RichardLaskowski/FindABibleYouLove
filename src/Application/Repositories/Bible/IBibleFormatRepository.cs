using Domain.Common.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleFormatRepository<TType> : IRepository<TType, BibleFormatEntity<TType>> where TType : class
{

}