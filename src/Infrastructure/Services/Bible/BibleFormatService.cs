using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

using Infrastructure.Mappers.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFormatService : BaseService<string, BibleFormatEntity<string>, BibleFormatContract<string>>, IBibleFormatService<string> 
{
    protected IBibleFormatRepository<string> BibleFormatRepo => (IBibleFormatRepository<string>)_repo;
    protected IBibleFormatMapper<string> BibleFormatMapper => (IBibleFormatMapper<string>)_mapper;

    public BibleFormatService(IBibleFormatRepository<string> repo, IBibleFormatMapper<string> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleFormatContract<string>> CreateAsync(BibleFormatContract<string> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleFormatContract<string> contract) => throw new NotImplementedException();
    public override Task<BibleFormatContract<string>> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleFormatContract<string>>> GetAllAsync() => await BibleFormatMapper.MapAllAsync(await BibleFormatRepo.GetAllAsync());
}