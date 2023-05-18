using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleCategoryMapper : StringBaseMapper<BibleCategoryEntity, BibleCategoryContract>, IBibleCategoryMapper 
{
    public override BibleCategoryEntity Map(BibleCategoryContract bibleCategoryContract)
    {
        BibleCategoryEntity bibleCategoryEntity = new(
            bibleCategoryContract.Id,
            bibleCategoryContract.CategoryName,
            bibleCategoryContract.CategoryDescription);

        return bibleCategoryEntity;
    }

    public override BibleCategoryContract Map(BibleCategoryEntity bibleCategoryEntity)
    {
        BibleCategoryContract bibleCategoryContract = new(
            bibleCategoryEntity.BibleCategoryId,
            bibleCategoryEntity.CategoryName,
            bibleCategoryEntity.CategoryDescription);

        return bibleCategoryContract;
    }

    public override IEnumerable<BibleCategoryEntity> MapAll(IEnumerable<BibleCategoryContract> bibleCategoryContracts)
    {
        List<BibleCategoryEntity> bibleCategoryEntities = new();

        foreach (BibleCategoryContract bibleCategoryContract in bibleCategoryContracts)
        {
            bibleCategoryEntities.Add(Map(bibleCategoryContract));
        }

        return bibleCategoryEntities;
    }

    public override IEnumerable<BibleCategoryContract> MapAll(IEnumerable<BibleCategoryEntity> bibleCategoryEntities)
    {
        List<BibleCategoryContract> bibleCategoryContracts = new();

        foreach (BibleCategoryEntity bibleCategoryEntity in bibleCategoryEntities)
        {
            bibleCategoryContracts.Add(Map(bibleCategoryEntity));
        }

        return bibleCategoryContracts;
    }

    public override async Task<BibleCategoryEntity> MapAsync(BibleCategoryContract bibleCategoryContract) => await Task.Run(() => Map(bibleCategoryContract));
    public override async Task<BibleCategoryContract> MapAsync(BibleCategoryEntity bibleCategoryEntity) => await Task.Run(() => Map(bibleCategoryEntity));

    public override async Task<IEnumerable<BibleCategoryEntity>> MapAllAsync(IEnumerable<BibleCategoryContract> bibleCategoryContracts)
    {
        IList<BibleCategoryEntity> bibleCategoryEntities = new List<BibleCategoryEntity>();

        foreach(BibleCategoryContract bibleCategoryContract in bibleCategoryContracts)
        {
            bibleCategoryEntities.Add(await MapAsync(bibleCategoryContract));
        }

        return bibleCategoryEntities;
    }

    public override async Task<IEnumerable<BibleCategoryContract>> MapAllAsync(IEnumerable<BibleCategoryEntity> bibleCategoryEntities)
    {
        IList<BibleCategoryContract> bibleCategoryContracts = new List<BibleCategoryContract>();

        foreach (BibleCategoryEntity bibleCategoryEntity in bibleCategoryEntities)
        {
            bibleCategoryContracts.Add(await MapAsync(bibleCategoryEntity));
        }

        return bibleCategoryContracts;
    }
}
