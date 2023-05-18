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
            bibleCategoryContract.BibleCategoryId,
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

    public override IEnumerable<BibleCategoryEntity> MapAll(IEnumerable<BibleCategoryContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryContract> MapAll(IEnumerable<BibleCategoryEntity> values) => throw new NotImplementedException();
    public override async Task<BibleCategoryEntity> MapAsync(BibleCategoryContract bibleCategoryContract) => await Task.Run(() => new BibleCategoryEntity(bibleCategoryContract.BibleCategoryId, bibleCategoryContract.CategoryName, bibleCategoryContract.CategoryDescription));

    public override async Task<BibleCategoryContract> MapAsync(BibleCategoryEntity value) => await Task.Run(() => new BibleCategoryContract(value.BibleCategoryId, value.CategoryName, value.CategoryDescription));

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
