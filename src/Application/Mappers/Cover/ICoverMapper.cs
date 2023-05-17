using Domain.Base.Interfaces;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverMapper<TType> : IBaseMapper<CoverEntity<TType>, CoverContract> where TType : class { }
