using System.Text.Json;

using Application.Repositories.Bible;

using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;
public class BibleCategoryFileRepository : FileRepository<string, BibleCategoryEntity>, IBibleCategoryRepository
{
    protected Dictionary<string, BibleCategoryEntity> BibleCategoryDictionary => (Dictionary<string, BibleCategoryEntity>)Dictionary;
    
    public BibleCategoryFileRepository() : base("../../docs/data/Bible/BibleCategories.json")
    {

    }

    public override void Seed()
    {
        JsonString = File.ReadAllText(Path);

        IEnumerable<BibleCategoryEntity> bibleCategoryEntities = JsonSerializer.Deserialize<IEnumerable<BibleCategoryEntity>>(JsonString)!;

        foreach (BibleCategoryEntity bibleCategoryEntity in bibleCategoryEntities)
        {
            BibleCategoryDictionary.Add(bibleCategoryEntity.BibleCategoryId, bibleCategoryEntity);
        }
    }

    public override BibleCategoryEntity Add(BibleCategoryEntity entity)
    {
        BibleCategoryDictionary.Add(entity.BibleCategoryId, entity);
        return entity;
    }

    public override IEnumerable<BibleCategoryEntity> AddRange(IEnumerable<BibleCategoryEntity> entities) => throw new NotImplementedException();
    public override void Remove(BibleCategoryEntity entity) => throw new NotImplementedException();
    public override void RemoveRange(IEnumerable<BibleCategoryEntity> entities) => throw new NotImplementedException();
    public override BibleCategoryEntity Get(string id) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryEntity> GetAll() => BibleCategoryDictionary.Values.ToList();
    public override Task<BibleCategoryEntity> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleCategoryEntity>> GetAllAsync() => await Task.Run(() => GetAll());

    public override void Update(BibleCategoryEntity entity) => throw new NotImplementedException();
    public override void UpdateRange(IEnumerable<BibleCategoryEntity> entities) => throw new NotImplementedException();
    public override IEnumerable<BibleCategoryEntity> Find(Func<BibleCategoryEntity, bool> predicate) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleCategoryEntity>> FindAsync(Func<BibleCategoryEntity, bool> predicate) => throw new NotImplementedException();
}
