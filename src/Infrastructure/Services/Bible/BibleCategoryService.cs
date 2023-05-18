using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Base.Classes.Services;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryService : StringBaseService<BibleCategoryContract, BibleCategoryEntity>, IBibleCategoryService 
{
    protected IBibleCategoryRepository BibleCategoryRepository => (IBibleCategoryRepository)_repo;
    protected IBibleCategoryMapper BibleCategoryMapper => (IBibleCategoryMapper)_mapper;

    public BibleCategoryService(IBibleCategoryRepository repo, IBibleCategoryMapper mapper) : base(repo, mapper)
    {
    }

    public override async Task<BibleCategoryContract> CreateAsync(BibleCategoryContract contract)
    {
        Task<BibleCategoryEntity> contractConversionTask = BibleCategoryMapper.MapAsync(contract);
        BibleCategoryEntity bibleCategoryEntity = await contractConversionTask;
        Task<BibleCategoryContract> entityConversionTask = BibleCategoryMapper.MapAsync(bibleCategoryEntity);
        BibleCategoryRepository.Add(bibleCategoryEntity);
        contract = await entityConversionTask;
        return contract;
    }

    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleCategoryContract contract) => throw new NotImplementedException();
    public override async Task<BibleCategoryContract> GetAsync(string id) => await BibleCategoryMapper.MapAsync(await BibleCategoryRepository.GetAsync(id));
    public override async Task<IEnumerable<BibleCategoryContract>> GetAllAsync()
    {
        IEnumerable<BibleCategoryEntity> bibleCategoryEntities      = await BibleCategoryRepository.GetAllAsync();
        IEnumerable<BibleCategoryContract> bibleCategoryContracts   = await BibleCategoryMapper.MapAllAsync(bibleCategoryEntities);

        return bibleCategoryContracts;
    }
}