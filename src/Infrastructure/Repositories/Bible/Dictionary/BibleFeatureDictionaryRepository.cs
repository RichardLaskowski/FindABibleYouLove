using System.Text.Json;

using Application.Repositories.Bible;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureDictionaryRepository : DictionaryBaseRepository<string, BibleFeatureEntity>, IBibleFeatureRepository 
{
    protected Dictionary<string, BibleFeatureEntity> BibleFeatureDictionary => (Dictionary<string, BibleFeatureEntity>)Dictionary;

    public override BibleFeatureEntity Add(BibleFeatureEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity> AddRange(IEnumerable<BibleFeatureEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity> Find(Func<BibleFeatureEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleFeatureEntity>> FindAsync(Func<BibleFeatureEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleFeatureEntity Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override async Task<IEnumerable<BibleFeatureEntity>> GetAllAsync()
    {
        return await Task.Run(() => BibleFeatureDictionary.Values.ToList());
    }

    public override Task<BibleFeatureEntity> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleFeatureEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleFeatureEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleFeatureEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleFeatureEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed()
    {
        string jsonPath = "../../docs/data/Bible/";
        string fileName = "BibleFeatures.json";
        string jsonString = File.ReadAllText(jsonPath + fileName);
        List<BibleFeatureEntity> bibleFeatureEntities = JsonSerializer.Deserialize<List<BibleFeatureEntity>>(jsonString)!;

        foreach (BibleFeatureEntity bibleFeatureEntity in  bibleFeatureEntities)
        {
            BibleFeatureDictionary[Guid.NewGuid().ToString()] = bibleFeatureEntity;
        }
    }
}

