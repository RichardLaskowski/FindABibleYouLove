using Domain.Base.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleRepository<TType> : IBaseRepository<TType, BibleEntity<TType>> where TType : class
{

}