using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleCategoryMapper : BaseMapper<string, BibleCategoryEntity<string>, BibleCategoryContract>, IBibleCategoryMapper<string> 
{
    public override BibleCategoryEntity<string> Map(BibleCategoryContract bibleCategoryContract)
    {
        BibleCategoryEntity<string> bibleCategoryEntity = new(
            bibleCategoryContract.BibleCategoryId,
            bibleCategoryContract.CategoryName,
            bibleCategoryContract.CategoryDescription);

        return bibleCategoryEntity;
    }

    public override BibleCategoryContract Map(BibleCategoryEntity<string> bibleCategoryEntity)
    {
        BibleCategoryContract bibleCategoryContract = new(
            bibleCategoryEntity.BibleCategoryID,
            bibleCategoryEntity.CategoryName,
            bibleCategoryEntity.CategoryDescription);

        return bibleCategoryContract;
    }

    public override IEnumerable<BibleCategoryEntity<string>> MapAll(IEnumerable<BibleCategoryContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryContract> MapAll(IEnumerable<BibleCategoryEntity<string>> values) => throw new NotImplementedException();
    public override async Task<BibleCategoryEntity<string>> MapAsync(BibleCategoryContract bibleCategoryContract) => await Task.Run(() => new BibleCategoryEntity<string>(bibleCategoryContract.BibleCategoryId, bibleCategoryContract.CategoryName, bibleCategoryContract.CategoryDescription));

    public override async Task<BibleCategoryContract> MapAsync(BibleCategoryEntity<string> value) => await Task.Run(() => new BibleCategoryContract(value.BibleCategoryID, value.CategoryName, value.CategoryDescription));

    public override async Task<IEnumerable<BibleCategoryEntity<string>>> MapAllAsync(IEnumerable<BibleCategoryContract> bibleCategoryContracts)
    {
        IList<BibleCategoryEntity<string>> bibleCategoryEntities = new List<BibleCategoryEntity<string>>();

        foreach(BibleCategoryContract bibleCategoryContract in bibleCategoryContracts)
        {
            bibleCategoryEntities.Add(await MapAsync(bibleCategoryContract));
        }

        return bibleCategoryEntities;
    }

    public override async Task<IEnumerable<BibleCategoryContract>> MapAllAsync(IEnumerable<BibleCategoryEntity<string>> bibleCategoryEntities)
    {
        IList<BibleCategoryContract> bibleCategoryContracts = new List<BibleCategoryContract>();

        foreach (BibleCategoryEntity<string> bibleCategoryEntity in bibleCategoryEntities)
        {
            bibleCategoryContracts.Add(await MapAsync(bibleCategoryEntity));
        }

        return bibleCategoryContracts;
    }
}
