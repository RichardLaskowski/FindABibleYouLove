using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;
using Domain.Base.Classes.Services;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleService : StringBaseService<BibleContract, BibleEntity>, IBibleService 
{
    protected IBibleRepository Repository => (IBibleRepository)_repo;
    protected IBibleMapper Mapper => (IBibleMapper)_mapper;

    public BibleService(IBibleRepository repo, IBibleMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<string> CreateAsync(BibleContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleContract contract) => throw new NotImplementedException();
    public override Task<BibleContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleContract>> GetAllAsync() => throw new NotImplementedException();
}