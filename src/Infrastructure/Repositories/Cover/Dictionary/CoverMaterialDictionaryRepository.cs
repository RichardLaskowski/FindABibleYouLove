using Application.Repositories.Cover;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverMaterialDictionaryRepository<TType> : DictionaryBaseRepository<TType, CoverMaterialEntity>, ICoverMaterialRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverMaterialEntity> CoverMaterialDictionary => (Dictionary<TType, CoverMaterialEntity>)Dictionary;

    public override CoverMaterialEntity Add(CoverMaterialEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverMaterialEntity> AddRange(IEnumerable<CoverMaterialEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverMaterialEntity> Find(Func<CoverMaterialEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverMaterialEntity>> FindAsync(Func<CoverMaterialEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override CoverMaterialEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverMaterialEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverMaterialEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CoverMaterialEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CoverMaterialEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<CoverMaterialEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(CoverMaterialEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<CoverMaterialEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

