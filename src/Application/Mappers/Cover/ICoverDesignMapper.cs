using Domain.Common.Interfaces;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverDesignMapper<TType>
    : IMapper<CoverDesignEntity<TType>, CoverDesignContract<TType>> 
    where TType : class
{
}
