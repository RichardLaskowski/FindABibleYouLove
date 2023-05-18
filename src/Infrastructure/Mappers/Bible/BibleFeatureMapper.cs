using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleFeatureMapper : StringBaseMapper<BibleFeatureEntity, BibleFeatureContract>, IBibleFeatureMapper
{
    public override BibleFeatureEntity Map(BibleFeatureContract value) => throw new NotImplementedException();
    public override BibleFeatureContract Map(BibleFeatureEntity value) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureEntity> MapAll(IEnumerable<BibleFeatureContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureContract> MapAll(IEnumerable<BibleFeatureEntity> values) => throw new NotImplementedException();
    public override async Task<BibleFeatureEntity> MapAsync(BibleFeatureContract value)
    {
        return await Task.Run(() => new BibleFeatureEntity(value.BibleFeatureId, value.FeatureName));
    }

    public override async Task<BibleFeatureContract> MapAsync(BibleFeatureEntity value)
    {
        return await Task.Run(() => new BibleFeatureContract(value.BibleFeatureId, value.FeatureName));
    }

    public override async Task<IEnumerable<BibleFeatureEntity>> MapAllAsync(IEnumerable<BibleFeatureContract> values)
    {
        List<BibleFeatureEntity> entities = new();

        foreach(var value in values)
        {
            entities.Add(await MapAsync(value));
        }

        return entities;
    }

    public override async Task<IEnumerable<BibleFeatureContract>> MapAllAsync(IEnumerable<BibleFeatureEntity> values)
    {
        List<BibleFeatureContract> contracts = new();

        foreach (var value in values)
        {
            contracts.Add(await MapAsync(value));
        }

        return contracts;
    }
}
