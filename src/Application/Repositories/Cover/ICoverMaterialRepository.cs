using Domain.Base.Interfaces;
using Domain.Entities.Cover;

namespace Application.Repositories.Cover;

public interface ICoverMaterialRepository<TType> : IBaseRepository<TType, CoverMaterialEntity<TType>> where TType : class
{

}