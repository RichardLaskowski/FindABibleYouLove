using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleFeatureMapper : BaseMapper<string, BibleFeatureEntity<string>, BibleFeatureContract>, IBibleFeatureMapper<string>
{
    public override BibleFeatureEntity<string> Map(BibleFeatureContract value) => throw new NotImplementedException();
    public override BibleFeatureContract Map(BibleFeatureEntity<string> value) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureEntity<string>> MapAll(IEnumerable<BibleFeatureContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureContract> MapAll(IEnumerable<BibleFeatureEntity<string>> values) => throw new NotImplementedException();
    public override async Task<BibleFeatureEntity<string>> MapAsync(BibleFeatureContract value)
    {
        return await Task.Run(() => new BibleFeatureEntity<string>(value.BibleFeatureId, value.FeatureName, value.FeatureDescription));
    }

    public override async Task<BibleFeatureContract> MapAsync(BibleFeatureEntity<string> value)
    {
        return await Task.Run(() => new BibleFeatureContract(value.BibleFeatureID, value.FeatureName, value.FeatureDescription));
    }

    public override async Task<IEnumerable<BibleFeatureEntity<string>>> MapAllAsync(IEnumerable<BibleFeatureContract> values)
    {
        List<BibleFeatureEntity<string>> entities = new();

        foreach(var value in values)
        {
            entities.Add(await MapAsync(value));
        }

        return entities;
    }

    public override async Task<IEnumerable<BibleFeatureContract>> MapAllAsync(IEnumerable<BibleFeatureEntity<string>> values)
    {
        List<BibleFeatureContract> contracts = new();

        foreach (var value in values)
        {
            contracts.Add(await MapAsync(value));
        }

        return contracts;
    }
}
