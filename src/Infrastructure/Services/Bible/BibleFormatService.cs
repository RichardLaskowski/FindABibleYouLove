using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;
using Domain.Base.Classes.Services;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFormatService : StringBaseService<BibleFormatContract, BibleFormatEntity>, IBibleFormatService 
{
    protected IBibleFormatRepository BibleFormatRepo => (IBibleFormatRepository)_repo;
    protected IBibleFormatMapper BibleFormatMapper => (IBibleFormatMapper)_mapper;

    public BibleFormatService(IBibleFormatRepository repo, IBibleFormatMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<string> CreateAsync(BibleFormatContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleFormatContract contract) => throw new NotImplementedException();
    public override Task<BibleFormatContract> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleFormatContract>> GetAllAsync() => await BibleFormatMapper.MapAllAsync(await BibleFormatRepo.GetAllAsync());
}