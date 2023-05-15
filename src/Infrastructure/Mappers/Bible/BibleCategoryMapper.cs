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
    public override Task<BibleCategoryEntity<string>> MapAsync(BibleCategoryContract<string> value) => throw new NotImplementedException();
    public override Task<BibleCategoryContract<string>> MapAsync(BibleCategoryEntity<string> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleCategoryEntity<string>>> MapAllAsync(IEnumerable<BibleCategoryContract<string>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleCategoryContract<string>>> MapAllAsync(IEnumerable<BibleCategoryEntity<string>> values) => throw new NotImplementedException();
}
