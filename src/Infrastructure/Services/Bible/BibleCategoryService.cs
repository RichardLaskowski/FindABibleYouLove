using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;
using Domain.Base.Interfaces;
using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryService : IStringBaseService<BibleCategoryContract>, IBibleCategoryService 
{
    protected IBibleCategoryRepository<string> BibleCategoryRepo => (IBibleCategoryRepository<string>)_repo;
    protected IBibleCategoryMapper<string> BibleCategoryMapper => (IBibleCategoryMapper<string>)_mapper;

    public BibleCategoryService(IBibleCategoryRepository<string> repo, IBibleCategoryMapper<string> mapper) : base(repo, mapper)
    {
    }

    public override Task<BibleCategoryContract> CreateAsync(BibleCategoryContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleCategoryContract contract) => throw new NotImplementedException();
    public override async Task<BibleCategoryContract> GetAsync(string id) => await BibleCategoryMapper.MapAsync(await BibleCategoryRepo.GetAsync(id));
    public override async Task<IEnumerable<BibleCategoryContract>> GetAllAsync() => await BibleCategoryMapper.MapAllAsync(await BibleCategoryRepo.GetAllAsync());
}