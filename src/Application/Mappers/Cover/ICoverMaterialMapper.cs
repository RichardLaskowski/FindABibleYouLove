using Domain.Base.Interfaces;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverMaterialMapper<TType> : IBaseMapper<CoverMaterialEntity<TType>, CoverMaterialContract> where TType : class { }
