using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleFeatureMapper<TType> : BaseMapper<TType, BibleFeatureEntity<TType>, BibleFeatureContract<TType>>, IBibleFeatureMapper<TType> where TType : class
{
    public override BibleFeatureEntity<TType> Map(BibleFeatureContract<TType> value) => throw new NotImplementedException();
    public override BibleFeatureContract<TType> Map(BibleFeatureEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureEntity<TType>> MapAll(IEnumerable<BibleFeatureContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureContract<TType>> MapAll(IEnumerable<BibleFeatureEntity<TType>> values) => throw new NotImplementedException();
    public override Task<BibleFeatureEntity<TType>> MapAsync(BibleFeatureContract<TType> value) => throw new NotImplementedException();
    public override Task<BibleFeatureContract<TType>> MapAsync(BibleFeatureEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFeatureEntity<TType>>> MapAllAsync(IEnumerable<BibleFeatureContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFeatureContract<TType>>> MapAllAsync(IEnumerable<BibleFeatureEntity<TType>> values) => throw new NotImplementedException();
}
