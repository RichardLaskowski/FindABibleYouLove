using Domain.Common.Interfaces;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleFeatureRepository<TType> : IRepository<TType, BibleFeatureEntity<TType>> where TType : class
{

}