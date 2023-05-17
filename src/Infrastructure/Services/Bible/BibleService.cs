using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleService : BaseService<string, BibleEntity<string>, BibleContract<string>> , IBibleService<string> 
{
    protected IBibleRepository<string> Repository => (IBibleRepository<string>)_repo;
    protected IBibleMapper<string> Mapper => (IBibleMapper<string>)_mapper;

    public BibleService(IBibleRepository<string> repo, IBibleMapper<string> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleContract<string>> CreateAsync(BibleContract<string> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleContract<string> contract) => throw new NotImplementedException();
    public override Task<BibleContract<string>> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleContract<string>>> GetAllAsync() => throw new NotImplementedException();
}