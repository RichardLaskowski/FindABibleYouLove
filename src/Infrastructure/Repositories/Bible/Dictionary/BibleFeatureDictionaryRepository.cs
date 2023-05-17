using System.Text.Json;

using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureDictionaryRepository : DictionaryRepository<string, BibleFeatureEntity<string>>, IBibleFeatureRepository<string> 
{
    protected Dictionary<string, BibleFeatureEntity<string>> BibleFeatureDictionary => (Dictionary<string, BibleFeatureEntity<string>>)Dictionary;

    public override BibleFeatureEntity<string> Add(BibleFeatureEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity<string>> AddRange(IEnumerable<BibleFeatureEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity<string>> Find(Func<BibleFeatureEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleFeatureEntity<string>>> FindAsync(Func<BibleFeatureEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleFeatureEntity<string> Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity<string>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override async Task<IEnumerable<BibleFeatureEntity<string>>> GetAllAsync()
    {
        return await Task.Run(() => BibleFeatureDictionary.Values.ToList());
    }

    public override Task<BibleFeatureEntity<string>> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleFeatureEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleFeatureEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleFeatureEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleFeatureEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed()
    {
        string jsonPath = "../../docs/data/Bible/";
        string fileName = "BibleFeatures.json";
        string jsonString = File.ReadAllText(jsonPath + fileName);
        List<BibleFeatureEntity<string>> bibleFeatureEntities = JsonSerializer.Deserialize<List<BibleFeatureEntity<string>>>(jsonString)!;

        foreach (BibleFeatureEntity<string> bibleFeatureEntity in  bibleFeatureEntities)
        {
            BibleFeatureDictionary[Guid.NewGuid().ToString()] = bibleFeatureEntity;
        }
    }
}

