using Domain.Base.Interfaces.Repositories;
using Domain.Entities.Bible;

namespace Application.Repositories.Bible;

public interface IBibleTranslationRepository: IStringBaseRepository<BibleTranslationEntity>
{

}