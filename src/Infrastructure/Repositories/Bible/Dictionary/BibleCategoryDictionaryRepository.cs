using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryDictionaryRepository : DictionaryRepository<string, BibleCategoryEntity<string>>, IBibleCategoryRepository<string> 
{
    protected Dictionary<string, BibleCategoryEntity<string>> BibleCategoryDictionary => (Dictionary<string, BibleCategoryEntity<string>>)Dictionary;

    public override BibleCategoryEntity<string> Add(BibleCategoryEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity<string>> AddRange(IEnumerable<BibleCategoryEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity<string>> Find(Func<BibleCategoryEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleCategoryEntity<string>>> FindAsync(Func<BibleCategoryEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleCategoryEntity<string> Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleCategoryEntity<string>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override async Task<IEnumerable<BibleCategoryEntity<string>>> GetAllAsync() => await Task.Run(() => BibleCategoryDictionary.Values.ToList<BibleCategoryEntity<string>>());

    public override Task<BibleCategoryEntity<string>> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleCategoryEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleCategoryEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleCategoryEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleCategoryEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed()
    {
        BibleCategoryEntity<string> TextCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Text", categoryDescription: string.Empty);
        BibleCategoryEntity<string> StudyCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Study", categoryDescription: string.Empty);
        BibleCategoryEntity<string> JournalingCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Journaling", categoryDescription: string.Empty);
        BibleCategoryEntity<string> ReadersCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Readers", categoryDescription: string.Empty);
        BibleCategoryEntity<string> MinistryCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Ministry", categoryDescription: string.Empty);
        BibleCategoryEntity<string> ChildrenAndTeensCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Children and Teens", categoryDescription: string.Empty);
        BibleCategoryEntity<string> PremiumCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Premium", categoryDescription: string.Empty);
        BibleCategoryEntity<string> DevotionalCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Devotional", categoryDescription: string.Empty);
        BibleCategoryEntity<string> OtherCategory = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Other", categoryDescription: string.Empty);

        BibleCategoryDictionary[key: TextCategory.BibleCategoryID] = TextCategory;
        BibleCategoryDictionary[key: StudyCategory.BibleCategoryID] = StudyCategory;
        BibleCategoryDictionary[key: JournalingCategory.BibleCategoryID] = JournalingCategory;
        BibleCategoryDictionary[key: ReadersCategory.BibleCategoryID] = ReadersCategory;
        BibleCategoryDictionary[key: MinistryCategory.BibleCategoryID] = MinistryCategory;
        BibleCategoryDictionary[key: ChildrenAndTeensCategory.BibleCategoryID] = ChildrenAndTeensCategory;
        BibleCategoryDictionary[key: PremiumCategory.BibleCategoryID] = PremiumCategory;
        BibleCategoryDictionary[key: DevotionalCategory.BibleCategoryID] = DevotionalCategory;
        BibleCategoryDictionary[key: OtherCategory.BibleCategoryID] = OtherCategory;
    }
}


