using Application.Repositories.Cover;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverDesignDictionaryRepository<TType> : DictionaryBaseRepository<TType, CoverDesignEntity>, ICoverDesignRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverDesignEntity> CoverDesignDictionary => (Dictionary<TType, CoverDesignEntity>)Dictionary;

    public override CoverDesignEntity Add(CoverDesignEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverDesignEntity> AddRange(IEnumerable<CoverDesignEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverDesignEntity> Find(Func<CoverDesignEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverDesignEntity>> FindAsync(Func<CoverDesignEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override CoverDesignEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverDesignEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverDesignEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CoverDesignEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CoverDesignEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<CoverDesignEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(CoverDesignEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<CoverDesignEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

