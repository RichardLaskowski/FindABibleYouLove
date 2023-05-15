using Domain.Common.Interfaces;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverColorMapper<TType> : IMapper<CoverColorEntity<TType>, CoverColorContract<TType>> where TType : class
{
}
