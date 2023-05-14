using Domain.Common.Interfaces;
using Domain.Entities.Cover;

namespace Application.Repositories.Cover;

public interface ICoverColorRepository<TType> : IRepository<TType, CoverColorEntity<TType>> where TType : class
{

}