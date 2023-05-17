using Domain.Base.Interfaces;
using Domain.Entities.Cover;

namespace Application.Repositories.Cover;

public interface ICoverRepository<TType> : IBaseRepository<TType, CoverEntity<TType>> where TType : class
{

}