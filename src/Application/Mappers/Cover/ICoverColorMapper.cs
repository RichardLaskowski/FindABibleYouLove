using Domain.Base.Interfaces;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Application.Mappers.Cover;

public interface ICoverColorMapper<TType> : IBaseMapper<CoverColorEntity<TType>, CoverColorContract> where TType : class
{
}
