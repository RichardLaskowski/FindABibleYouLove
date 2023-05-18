using Application.Repositories.Bible;

using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;
public class BibleCategoryFileRepository : FileRepository<string, BibleCategoryEntity>, IBibleCategoryRepository
{
    public BibleCategoryFileRepository() : base("../../docs/data/Bible/BibleCategories.json")
    {

    }



    public override void Seed() => throw new NotImplementedException();
    public override BibleCategoryEntity Add(BibleCategoryEntity entity) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryEntity> AddRange(IEnumerable<BibleCategoryEntity> entities) => throw new NotImplementedException();
    public override void Remove(BibleCategoryEntity entity) => throw new NotImplementedException();
    public override void RemoveRange(IEnumerable<BibleCategoryEntity> entities) => throw new NotImplementedException();
    public override BibleCategoryEntity Get(string id) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryEntity> GetAll() => throw new NotImplementedException();
    public override Task<BibleCategoryEntity> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleCategoryEntity>> GetAllAsync() => throw new NotImplementedException();
    public override void Update(BibleCategoryEntity entity) => throw new NotImplementedException();
    public override void UpdateRange(IEnumerable<BibleCategoryEntity> entities) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryEntity> Find(Func<BibleCategoryEntity, bool> predicate) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleCategoryEntity>> FindAsync(Func<BibleCategoryEntity, bool> predicate) => throw new NotImplementedException();
}
