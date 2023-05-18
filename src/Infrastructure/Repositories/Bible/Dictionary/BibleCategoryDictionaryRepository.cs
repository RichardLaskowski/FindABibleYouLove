using Application.Repositories.Bible;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryDictionaryRepository : DictionaryBaseRepository<string, BibleCategoryEntity>, IBibleCategoryRepository 
{
    protected Dictionary<string, BibleCategoryEntity> BibleCategoryDictionary => (Dictionary<string, BibleCategoryEntity>)Dictionary;

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

    public override BibleCategoryEntity Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override async Task<IEnumerable<BibleCategoryEntity>> GetAllAsync() => await Task.Run(() => BibleCategoryDictionary.Values.ToList<BibleCategoryEntity>());

    public override Task<BibleCategoryEntity> GetAsync(string id)
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

    public override void Seed()
    {
        BibleCategoryEntity TextCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Text", categoryDescription: string.Empty);
        BibleCategoryEntity StudyCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Study", categoryDescription: string.Empty);
        BibleCategoryEntity JournalingCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Journaling", categoryDescription: string.Empty);
        BibleCategoryEntity ReadersCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Readers", categoryDescription: string.Empty);
        BibleCategoryEntity MinistryCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Ministry", categoryDescription: string.Empty);
        BibleCategoryEntity ChildrenAndTeensCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Children and Teens", categoryDescription: string.Empty);
        BibleCategoryEntity PremiumCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Premium", categoryDescription: string.Empty);
        BibleCategoryEntity DevotionalCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Devotional", categoryDescription: string.Empty);
        BibleCategoryEntity OtherCategory = new(BibleCategoryId: Guid.NewGuid().ToString(), categoryName: "Other", categoryDescription: string.Empty);

        BibleCategoryDictionary[key: TextCategory.BibleCategoryId] = TextCategory;
        BibleCategoryDictionary[key: StudyCategory.BibleCategoryId] = StudyCategory;
        BibleCategoryDictionary[key: JournalingCategory.BibleCategoryId] = JournalingCategory;
        BibleCategoryDictionary[key: ReadersCategory.BibleCategoryId] = ReadersCategory;
        BibleCategoryDictionary[key: MinistryCategory.BibleCategoryId] = MinistryCategory;
        BibleCategoryDictionary[key: ChildrenAndTeensCategory.BibleCategoryId] = ChildrenAndTeensCategory;
        BibleCategoryDictionary[key: PremiumCategory.BibleCategoryId] = PremiumCategory;
        BibleCategoryDictionary[key: DevotionalCategory.BibleCategoryId] = DevotionalCategory;
        BibleCategoryDictionary[key: OtherCategory.BibleCategoryId] = OtherCategory;
    }
}


