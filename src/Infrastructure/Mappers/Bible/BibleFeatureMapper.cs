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
    public override async Task<BibleFeatureEntity<string>> MapAsync(BibleFeatureContract<string> value)
    {
        return await Task.Run(() => new BibleFeatureEntity<string>(value.BibleFeatureID, value.FeatureName, value.FeatureDescription));
    }

    public override async Task<BibleFeatureContract<string>> MapAsync(BibleFeatureEntity<string> value)
    {
        return await Task.Run(() => new BibleFeatureContract<string>(value.BibleFeatureID, value.FeatureName, value.FeatureDescription));
    }

    public override async Task<IEnumerable<BibleFeatureEntity<string>>> MapAllAsync(IEnumerable<BibleFeatureContract<string>> values)
    {
        List<BibleFeatureEntity<string>> entities = new List<BibleFeatureEntity<string>>();

        foreach(var value in values)
        {
            entities.Add(await MapAsync(value));
        }

        return entities;
    }

    public override async Task<IEnumerable<BibleFeatureContract<string>>> MapAllAsync(IEnumerable<BibleFeatureEntity<string>> values)
    {
        List<BibleFeatureContract<string>> contracts = new List<BibleFeatureContract<string>>();

        foreach (var value in values)
        {
            contracts.Add(await MapAsync(value));
        }

        return contracts;
    }
}
