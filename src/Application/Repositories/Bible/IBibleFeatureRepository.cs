using Domain.Base.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleFeatureRepository<TType> : IBaseRepository<TType, BibleFeatureEntity<TType>> where TType : class
{

}