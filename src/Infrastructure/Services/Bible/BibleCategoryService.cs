using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryService : BaseService<string, BibleCategoryEntity<string>, BibleCategoryContract<string>>, IBibleCategoryService<string> 
{
    protected IBibleCategoryRepository<string> BibleCategoryRepo => (IBibleCategoryRepository<string>)_repo;
    protected IBibleCategoryMapper<string> BibleCategoryMapper => (IBibleCategoryMapper<string>)_mapper;

    public BibleCategoryService(IBibleCategoryRepository<string> repo, IBibleCategoryMapper<string> mapper) : base(repo, mapper)
    {
    }

    public override Task<BibleCategoryContract<string>> CreateAsync(BibleCategoryContract<string> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleCategoryContract<string> contract) => throw new NotImplementedException();
    public override async Task<BibleCategoryContract<string>> GetAsync(string id) => await BibleCategoryMapper.MapAsync(await BibleCategoryRepo.GetAsync(id));
    public override async Task<IEnumerable<BibleCategoryContract<string>>> GetAllAsync() => await BibleCategoryMapper.MapAllAsync(await BibleCategoryRepo.GetAllAsync());
}