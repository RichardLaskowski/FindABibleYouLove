using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleFeatureMapper : BaseMapper<string, BibleFeatureEntity<string>, BibleFeatureContract<string>>, IBibleFeatureMapper<string>
{
    public override BibleFeatureEntity<string> Map(BibleFeatureContract<string> value) => throw new NotImplementedException();
    public override BibleFeatureContract<string> Map(BibleFeatureEntity<string> value) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureEntity<string>> MapAll(IEnumerable<BibleFeatureContract<string>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureContract<string>> MapAll(IEnumerable<BibleFeatureEntity<string>> values) => throw new NotImplementedException();
    public override Task<BibleFeatureEntity<string>> MapAsync(BibleFeatureContract<string> value) => throw new NotImplementedException();
    public override Task<BibleFeatureContract<string>> MapAsync(BibleFeatureEntity<string> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFeatureEntity<string>>> MapAllAsync(IEnumerable<BibleFeatureContract<string>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFeatureContract<string>>> MapAllAsync(IEnumerable<BibleFeatureEntity<string>> values) => throw new NotImplementedException();
}
