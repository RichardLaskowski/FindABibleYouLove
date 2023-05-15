using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryService : BaseService<string, BibleCategoryEntity<string>, BibleCategoryContract<string>>, IBibleCategoryService<string> 
{
    protected IBibleCategoryRepository<string> Repository => (IBibleCategoryRepository<string>)_repo;
    protected IBibleCategoryMapper<string> Mapper => (IBibleCategoryMapper<string>)_mapper;

    public BibleCategoryService(IBibleCategoryRepository<string> repo, IBibleCategoryMapper<string> mapper) : base(repo, mapper)
    {
    }

    public override Task<BibleCategoryContract<string>> CreateAsync(BibleCategoryContract<string> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleCategoryContract<string> contract) => throw new NotImplementedException();
    public override async Task<BibleCategoryContract<string>> GetAsync(string id) => await _mapper.MapAsync(await _repo.GetAsync(id));
    public override async Task<IEnumerable<BibleCategoryContract<string>>> GetAllAsync() => await _mapper.MapAllAsync(await _repo.GetAllAsync());
}