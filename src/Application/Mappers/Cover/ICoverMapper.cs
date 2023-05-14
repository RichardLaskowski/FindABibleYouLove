using Domain.Common.Interfaces;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverMapper<TType> : IMapper<CoverEntity<TType>, CoverContract<TType>> where TType : class { }
