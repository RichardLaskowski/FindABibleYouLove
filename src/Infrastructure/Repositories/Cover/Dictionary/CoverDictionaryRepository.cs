using Application.Repositories.Cover;

using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverDictionaryRepository<TType> : DictionaryRepository<TType, CoverEntity<TType>>, ICoverRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverEntity<TType>> CoverDictionary => (Dictionary<TType, CoverEntity<TType>>)Dictionary;

    public override CoverEntity<TType> Add(CoverEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverEntity<TType>> AddRange(IEnumerable<CoverEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverEntity<TType>> Find(Func<CoverEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverEntity<TType>>> FindAsync(Func<CoverEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override CoverEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CoverEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CoverEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<CoverEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(CoverEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<CoverEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

