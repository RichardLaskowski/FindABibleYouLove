using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;
using Domain.Base.Classes.Services;
using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleTranslationService : StringBaseService<BibleTranslationContract>, IBibleTranslationService 
{
    protected IBibleTranslationRepository BibleTranslationRepo => (IBibleTranslationRepository)_repo;
    protected IBibleTranslationMapper<string> BibleTranslationMapper => (IBibleTranslationMapper<string>)_mapper;

    public BibleTranslationService(IBibleTranslationRepository bibleTranslationRepo, IBibleTranslationMapper<string> bibleTranslationMapper) : base(bibleTranslationRepo, bibleTranslationMapper)
    {

    }

    public override Task<BibleTranslationContract> CreateAsync(BibleTranslationContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleTranslationContract contract) => throw new NotImplementedException();
    public override Task<BibleTranslationContract> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleTranslationContract>> GetAllAsync() => await BibleTranslationMapper.MapAllAsync(await BibleTranslationRepo.GetAllAsync());
}