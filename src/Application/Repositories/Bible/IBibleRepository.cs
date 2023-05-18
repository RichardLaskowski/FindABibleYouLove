using Domain.Base.Interfaces.Repositories;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleRepository: IStringBaseRepository<BibleEntity>
{

}