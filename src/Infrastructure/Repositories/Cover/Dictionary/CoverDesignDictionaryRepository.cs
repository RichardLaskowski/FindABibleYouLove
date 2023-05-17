using Application.Repositories.Cover;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverDesignDictionaryRepository<TType> : DictionaryBaseRepository<TType, CoverDesignEntity<TType>>, ICoverDesignRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverDesignEntity<TType>> CoverDesignDictionary => (Dictionary<TType, CoverDesignEntity<TType>>)Dictionary;

    public override CoverDesignEntity<TType> Add(CoverDesignEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverDesignEntity<TType>> AddRange(IEnumerable<CoverDesignEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverDesignEntity<TType>> Find(Func<CoverDesignEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverDesignEntity<TType>>> FindAsync(Func<CoverDesignEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override CoverDesignEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverDesignEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverDesignEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CoverDesignEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CoverDesignEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<CoverDesignEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(CoverDesignEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<CoverDesignEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

