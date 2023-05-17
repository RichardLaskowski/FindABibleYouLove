using Application.Repositories.Bible;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryListRepository<TType> : ListBaseRepository<TType, BibleCategoryEntity>, IBibleCategoryRepository<TType> where TType : class
{
    protected List<BibleCategoryEntity> BibleCategoryList => (List<BibleCategoryEntity>)List;

    public override BibleCategoryEntity Add(BibleCategoryEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity> AddRange(IEnumerable<BibleCategoryEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity> Find(Func<BibleCategoryEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleCategoryEntity>> FindAsync(Func<BibleCategoryEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleCategoryEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleCategoryEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<BibleCategoryEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleCategoryEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleCategoryEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleCategoryEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleCategoryEntity> entities)
    {
        throw new NotImplementedException();
    }
}


