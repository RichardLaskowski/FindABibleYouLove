using Domain.Common.Interfaces;
using Domain.Entities.Cover;

namespace Application.Repositories.Cover;

public interface ICoverDesignRepository<TType> : IRepository<TType, CoverDesignEntity<TType>> where TType : class
{

}