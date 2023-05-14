using Domain.Common.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleRepository<TType> : IRepository<TType, BibleEntity<TType>> where TType : class
{

}