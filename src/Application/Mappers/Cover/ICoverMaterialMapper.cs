using Domain.Common.Interfaces;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverMaterialMapper<TType> : IMapper<CoverMaterialEntity<TType>, CoverMaterialContract<TType>> where TType : class { }
