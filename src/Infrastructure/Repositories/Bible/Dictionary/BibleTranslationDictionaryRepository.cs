using Application.Repositories.Bible;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleTranslationDictionaryRepository : DictionaryBaseRepository<string, BibleTranslationEntity<string>>, IBibleTranslationRepository 
{
    protected Dictionary<string, BibleTranslationEntity<string>> BibleTranslationDictionary => (Dictionary<string, BibleTranslationEntity<string>>)Dictionary;

    public override BibleTranslationEntity<string> Add(BibleTranslationEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleTranslationEntity<string>> AddRange(IEnumerable<BibleTranslationEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleTranslationEntity<string>> Find(Func<BibleTranslationEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleTranslationEntity<string>>> FindAsync(Func<BibleTranslationEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleTranslationEntity<string> Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleTranslationEntity<string>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override async Task<IEnumerable<BibleTranslationEntity<string>>> GetAllAsync() => await Task.Run(() => BibleTranslationDictionary.Values.ToList<BibleTranslationEntity<string>>());

    public override Task<BibleTranslationEntity<string>> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleTranslationEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleTranslationEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleTranslationEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleTranslationEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed()
    {
        BibleTranslationEntity<string> christianStandardBible = new(Guid.NewGuid().ToString(),"Christian Standard Bible", "CSB", string.Empty);
        BibleTranslationEntity<string> englishStandardVersion = new(Guid.NewGuid().ToString(),"English Standard Version", "ESV", string.Empty);
        BibleTranslationEntity<string> kingJamesVersion = new(Guid.NewGuid().ToString(),"King James Version", "KJV", string.Empty);
        BibleTranslationEntity<string> newAmericanStandardBible = new(Guid.NewGuid().ToString(),"New American Standard Bible", "NASB", string.Empty);
        BibleTranslationEntity<string> newEnglishTranslation = new(Guid.NewGuid().ToString(),"New English Translation", "NET", string.Empty);
        BibleTranslationEntity<string> newInternationalVersion = new(Guid.NewGuid().ToString(),"New International Version", "NIV", string.Empty);
        BibleTranslationEntity<string> newKingJamesVersion = new(Guid.NewGuid().ToString(),"New King James Version", "NKJV", string.Empty);
        BibleTranslationEntity<string> newLivingTranslation = new(Guid.NewGuid().ToString(),"New Living Translation", "NLT", string.Empty);
        BibleTranslationEntity<string> newRevisedStandardVersion = new(Guid.NewGuid().ToString(),"New Revised Standard Version", "NRSV", string.Empty);

        BibleTranslationDictionary[christianStandardBible.BibleTranslationId] = christianStandardBible;               
        BibleTranslationDictionary[englishStandardVersion.BibleTranslationId] = englishStandardVersion;               
        BibleTranslationDictionary[kingJamesVersion.BibleTranslationId] = kingJamesVersion;       
        BibleTranslationDictionary[newAmericanStandardBible.BibleTranslationId] = newAmericanStandardBible;               
        BibleTranslationDictionary[newEnglishTranslation.BibleTranslationId] = newEnglishTranslation;           
        BibleTranslationDictionary[newInternationalVersion.BibleTranslationId] = newInternationalVersion;               
        BibleTranslationDictionary[newKingJamesVersion.BibleTranslationId] = newKingJamesVersion;           
        BibleTranslationDictionary[newLivingTranslation.BibleTranslationId] = newLivingTranslation;           
        BibleTranslationDictionary[newRevisedStandardVersion.BibleTranslationId] = newRevisedStandardVersion;               

    }
}

