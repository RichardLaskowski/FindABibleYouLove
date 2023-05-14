using Domain.Common.Interfaces;
using Domain.Entities.Cover;

namespace Application.Repositories.Cover;

public interface ICoverMaterialRepository<TType> : IRepository<TType, CoverMaterialEntity<TType>> where TType : class
{

}