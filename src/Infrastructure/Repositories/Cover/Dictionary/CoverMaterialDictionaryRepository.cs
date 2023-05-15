using Application.Repositories.Cover;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverMaterialDictionaryRepository<TType> : DictionaryRepository<TType, CoverMaterialEntity<TType>>, ICoverMaterialRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverMaterialEntity<TType>> CoverMaterialDictionary => (Dictionary<TType, CoverMaterialEntity<TType>>)Dictionary;

    public override CoverMaterialEntity<TType> Add(CoverMaterialEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverMaterialEntity<TType>> AddRange(IEnumerable<CoverMaterialEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverMaterialEntity<TType>> Find(Func<CoverMaterialEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverMaterialEntity<TType>>> FindAsync(Func<CoverMaterialEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override CoverMaterialEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverMaterialEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverMaterialEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CoverMaterialEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CoverMaterialEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<CoverMaterialEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(CoverMaterialEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<CoverMaterialEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

