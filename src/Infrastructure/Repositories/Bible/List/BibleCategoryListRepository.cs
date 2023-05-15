using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryListRepository<TType> : ListRepository<TType, BibleCategoryEntity<TType>>, IBibleCategoryRepository<TType> where TType : class
{
    protected List<BibleCategoryEntity<TType>> BibleCategoryList => (List<BibleCategoryEntity<TType>>)List;

    public override BibleCategoryEntity<TType> Add(BibleCategoryEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity<TType>> AddRange(IEnumerable<BibleCategoryEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity<TType>> Find(Func<BibleCategoryEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleCategoryEntity<TType>>> FindAsync(Func<BibleCategoryEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleCategoryEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleCategoryEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<BibleCategoryEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleCategoryEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleCategoryEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleCategoryEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleCategoryEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }
}


