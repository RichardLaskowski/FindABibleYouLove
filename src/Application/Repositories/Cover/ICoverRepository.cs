using Domain.Common.Interfaces;
using Domain.Entities.Cover;

namespace Application.Repositories.Cover;

public interface ICoverRepository<TType> : IRepository<TType, CoverEntity<TType>> where TType : class
{

}