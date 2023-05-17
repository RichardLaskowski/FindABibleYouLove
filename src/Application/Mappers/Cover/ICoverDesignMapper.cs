using Domain.Base.Interfaces;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverDesignMapper<TType>: IBaseMapper<CoverDesignEntity<TType>, CoverDesignContract> where TType : class
{
}
