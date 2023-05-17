using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;
using Domain.Base.Classes.Services;
using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleService : StringBaseService<BibleContract>, IBibleService 
{
    protected IBibleRepository<string> Repository => (IBibleRepository<string>)_repo;
    protected IBibleMapper<string> Mapper => (IBibleMapper<string>)_mapper;

    public BibleService(IBibleRepository<string> repo, IBibleMapper<string> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleContract> CreateAsync(BibleContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleContract contract) => throw new NotImplementedException();
    public override Task<BibleContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleContract>> GetAllAsync() => throw new NotImplementedException();
}