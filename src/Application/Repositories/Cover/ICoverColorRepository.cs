using Domain.Base.Interfaces;
using Domain.Entities.Cover;

namespace Application.Repositories.Cover;

public interface ICoverColorRepository<TType> : IBaseRepository<TType, CoverColorEntity<TType>> where TType : class
{

}