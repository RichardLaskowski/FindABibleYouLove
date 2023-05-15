using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleDictionaryRepository<TType> : DictionaryRepository<TType, BibleEntity<TType>> , IBibleRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleEntity<TType>> BibleDictionary => (Dictionary<TType, BibleEntity<TType>>)Dictionary;

    public override BibleEntity<TType> Add(BibleEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity<TType>> AddRange(IEnumerable<BibleEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity<TType>> Find(Func<BibleEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleEntity<TType>>> FindAsync(Func<BibleEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<BibleEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

