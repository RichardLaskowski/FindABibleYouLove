using Domain.Common.Interfaces;
using FindABibleYouLove.Contracts.Cover;

namespace Application.Services.Cover;

public interface ICoverColorService<TType> : IService<TType, CoverColorContract<TType>>
    where TType : class
{

}