using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureDictionaryRepository<TType> : DictionaryRepository<TType, BibleFeatureEntity<TType>>, IBibleFeatureRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleFeatureEntity<TType>> BibleFeatureDictionary => (Dictionary<TType, BibleFeatureEntity<TType>>)Dictionary;

    public override BibleFeatureEntity<TType> Add(BibleFeatureEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity<TType>> AddRange(IEnumerable<BibleFeatureEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity<TType>> Find(Func<BibleFeatureEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleFeatureEntity<TType>>> FindAsync(Func<BibleFeatureEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleFeatureEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFeatureEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleFeatureEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<BibleFeatureEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleFeatureEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleFeatureEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleFeatureEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleFeatureEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

