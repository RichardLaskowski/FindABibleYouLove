using System.Text.Json;

using Application.Repositories.Bible;

using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureFileRepository : FileRepository<string, BibleFeatureEntity>, IBibleFeatureRepository
{
    protected Dictionary<string, BibleFeatureEntity> BibleFeatureDictionary => (Dictionary<string, BibleFeatureEntity>)Dictionary;

    public BibleFeatureFileRepository() : base("../../docs/data/Bible/BibleFeatures.json")
    {

    }

    public override void Seed()
    {
        JsonString = File.ReadAllText(Path);

        IEnumerable<BibleFeatureEntity> bibleFeatureEntities = JsonSerializer.Deserialize<IEnumerable<BibleFeatureEntity>>(JsonString)!;

        foreach (BibleFeatureEntity bibleFeatureEntity in bibleFeatureEntities)
        {
            BibleFeatureDictionary.Add(bibleFeatureEntity.BibleFeatureId, bibleFeatureEntity);
        }
    }

    public override string Add(BibleFeatureEntity entity)
    {
        BibleFeatureDictionary.Add(entity.BibleFeatureId, entity);
        return entity.BibleFeatureId;
    }

    public override IEnumerable<string> AddRange(IEnumerable<BibleFeatureEntity> entities) => throw new NotImplementedException();
    public override void Remove(BibleFeatureEntity entity) => throw new NotImplementedException();
    public override void RemoveRange(IEnumerable<BibleFeatureEntity> entities) => throw new NotImplementedException();
    public override BibleFeatureEntity Get(string id) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureEntity> GetAll() => BibleFeatureDictionary.Values.ToList();
    public override Task<BibleFeatureEntity> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleFeatureEntity>> GetAllAsync() => await Task.Run(() => GetAll());

    public override void Update(BibleFeatureEntity entity) => throw new NotImplementedException();
    public override void UpdateRange(IEnumerable<BibleFeatureEntity> entities) => throw new NotImplementedException();
    public override IEnumerable<BibleFeatureEntity> Find(Func<BibleFeatureEntity, bool> predicate) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFeatureEntity>> FindAsync(Func<BibleFeatureEntity, bool> predicate) => throw new NotImplementedException();
}
