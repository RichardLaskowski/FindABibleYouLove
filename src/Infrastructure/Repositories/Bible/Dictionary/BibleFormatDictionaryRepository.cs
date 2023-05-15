using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFormatDictionaryRepository<TType> : DictionaryRepository<TType, BibleFormatEntity<TType>>, IBibleFormatRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleFormatEntity<TType>> BibleFormatDictionary => (Dictionary<TType, BibleFormatEntity<TType>>)Dictionary;

    public override BibleFormatEntity<TType> Add(BibleFormatEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity<TType>> AddRange(IEnumerable<BibleFormatEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity<TType>> Find(Func<BibleFormatEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleFormatEntity<TType>>> FindAsync(Func<BibleFormatEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleFormatEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleFormatEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<BibleFormatEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleFormatEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleFormatEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleFormatEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleFormatEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

