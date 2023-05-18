using Domain.Base.Interfaces.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverDesignMapper : IStringBaseMapper<CoverDesignEntity, CoverDesignContract> 
{
}
