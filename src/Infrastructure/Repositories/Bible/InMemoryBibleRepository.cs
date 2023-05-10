using Domain.Common.Classes;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class InMemoryBibleRepository<TType> : SimpleInMemoryRepository<TType, BibleEntity<TType>> where TType : class
{
}

