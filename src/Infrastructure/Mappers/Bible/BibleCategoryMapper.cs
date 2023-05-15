using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleCategoryMapper<TType> : BaseMapper<TType, BibleCategoryEntity<TType>, BibleCategoryContract<TType>>, IBibleCategoryMapper<TType> where TType : class
{
    public override BibleCategoryEntity<TType> Map(BibleCategoryContract<TType> bibleCategoryContract)
    {
        BibleCategoryEntity<TType> bibleCategoryEntity = new(
            bibleCategoryContract.BibleCategoryID,
            bibleCategoryContract.CategoryName,
            bibleCategoryContract.CategoryDescription);

        return bibleCategoryEntity;
    }

    public override BibleCategoryContract<TType> Map(BibleCategoryEntity<TType> bibleCategoryEntity)
    {
        BibleCategoryContract<TType> bibleCategoryContract = new(
            bibleCategoryEntity.BibleCategoryID,
            bibleCategoryEntity.CategoryName,
            bibleCategoryEntity.CategoryDescription);

        return bibleCategoryContract;
    }

    public override IEnumerable<BibleCategoryEntity<TType>> MapAll(IEnumerable<BibleCategoryContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryContract<TType>> MapAll(IEnumerable<BibleCategoryEntity<TType>> values) => throw new NotImplementedException();
    public override Task<BibleCategoryEntity<TType>> MapAsync(BibleCategoryContract<TType> value) => throw new NotImplementedException();
    public override Task<BibleCategoryContract<TType>> MapAsync(BibleCategoryEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleCategoryEntity<TType>>> MapAllAsync(IEnumerable<BibleCategoryContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleCategoryContract<TType>>> MapAllAsync(IEnumerable<BibleCategoryEntity<TType>> values) => throw new NotImplementedException();
}
