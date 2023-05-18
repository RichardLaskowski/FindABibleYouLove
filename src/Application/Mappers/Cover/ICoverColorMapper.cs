using Domain.Base.Interfaces.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverColorMapper : IStringBaseMapper<CoverColorEntity, CoverColorContract>
{
}
