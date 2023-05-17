using Domain.Base.Interfaces;
using Domain.Entities.Cover;

namespace Application.Repositories.Cover;

public interface ICoverDesignRepository<TType> : IBaseRepository<TType, CoverDesignEntity<TType>> where TType : class
{

}