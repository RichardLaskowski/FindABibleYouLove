using Domain.Common.Classes;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class InMemoryBibleCategoryRepository<TType> : SimpleInMemoryRepository<TType, BibleCategoryEntity<TType>> where TType : class
{
}


