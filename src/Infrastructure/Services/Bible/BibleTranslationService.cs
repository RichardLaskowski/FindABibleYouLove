using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleTranslationService : BaseService<string, BibleTranslationEntity<string>, BibleTranslationContract<string>>, IBibleTranslationService<string> 
{
    protected IBibleTranslationRepository<string> BibleTranslationRepo => (IBibleTranslationRepository<string>)_repo;
    protected IBibleTranslationMapper<string> BibleTranslationMapper => (IBibleTranslationMapper<string>)_mapper;

    public BibleTranslationService(IBibleTranslationRepository<string> bibleTranslationRepo, IBibleTranslationMapper<string> bibleTranslationMapper) : base(bibleTranslationRepo, bibleTranslationMapper)
    {

    }

    public override Task<BibleTranslationContract<string>> CreateAsync(BibleTranslationContract<string> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleTranslationContract<string> contract) => throw new NotImplementedException();
    public override Task<BibleTranslationContract<string>> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleTranslationContract<string>>> GetAllAsync() => await BibleTranslationMapper.MapAllAsync(await BibleTranslationRepo.GetAllAsync());
}