using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleCategoryMapper : BaseMapper<string, BibleCategoryEntity<string>, BibleCategoryContract<string>>, IBibleCategoryMapper<string> 
{
    public override BibleCategoryEntity<string> Map(BibleCategoryContract<string> bibleCategoryContract)
    {
        BibleCategoryEntity<string> bibleCategoryEntity = new(
            bibleCategoryContract.BibleCategoryID,
            bibleCategoryContract.CategoryName,
            bibleCategoryContract.CategoryDescription);

        return bibleCategoryEntity;
    }

    public override BibleCategoryContract<string> Map(BibleCategoryEntity<string> bibleCategoryEntity)
    {
        BibleCategoryContract<string> bibleCategoryContract = new(
            bibleCategoryEntity.BibleCategoryID,
            bibleCategoryEntity.CategoryName,
            bibleCategoryEntity.CategoryDescription);

        return bibleCategoryContract;
    }

    public override IEnumerable<BibleCategoryEntity<string>> MapAll(IEnumerable<BibleCategoryContract<string>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryContract<string>> MapAll(IEnumerable<BibleCategoryEntity<string>> values) => throw new NotImplementedException();
    public override async Task<BibleCategoryEntity<string>> MapAsync(BibleCategoryContract<string> bibleCategoryContract) => await Task.Run(() => new BibleCategoryEntity<string>(bibleCategoryContract.BibleCategoryID, bibleCategoryContract.CategoryName, bibleCategoryContract.CategoryDescription));

    public override async Task<BibleCategoryContract<string>> MapAsync(BibleCategoryEntity<string> value) => await Task.Run(() => new BibleCategoryContract<string>(value.BibleCategoryID, value.CategoryName, value.CategoryDescription));

    public override async Task<IEnumerable<BibleCategoryEntity<string>>> MapAllAsync(IEnumerable<BibleCategoryContract<string>> bibleCategoryContracts)
    {
        IList<BibleCategoryEntity<string>> bibleCategoryEntities = new List<BibleCategoryEntity<string>>();

        foreach(BibleCategoryContract<string> bibleCategoryContract in bibleCategoryContracts)
        {
            bibleCategoryEntities.Add(await MapAsync(bibleCategoryContract));
        }

        return bibleCategoryEntities;
    }

    public override async Task<IEnumerable<BibleCategoryContract<string>>> MapAllAsync(IEnumerable<BibleCategoryEntity<string>> bibleCategoryEntities)
    {
        IList<BibleCategoryContract<string>> bibleCategoryContracts = new List<BibleCategoryContract<string>>();

        foreach (BibleCategoryEntity<string> bibleCategoryEntity in bibleCategoryEntities)
        {
            bibleCategoryContracts.Add(await MapAsync(bibleCategoryEntity));
        }

        return bibleCategoryContracts;
    }
}
