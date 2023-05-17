using Application.Repositories.Bible;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFormatDictionaryRepository : DictionaryBaseRepository<string, BibleFormatEntity<string>>, IBibleFormatRepository<string> 
{
    protected Dictionary<string, BibleFormatEntity<string>> BibleFormatDictionary => (Dictionary<string, BibleFormatEntity<string>>)Dictionary;

    public override BibleFormatEntity<string> Add(BibleFormatEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity<string>> AddRange(IEnumerable<BibleFormatEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity<string>> Find(Func<BibleFormatEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleFormatEntity<string>>> FindAsync(Func<BibleFormatEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleFormatEntity<string> Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity<string>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override async Task<IEnumerable<BibleFormatEntity<string>>> GetAllAsync() => await Task.Run(() => BibleFormatDictionary.Values.ToList<BibleFormatEntity<string>>());

    public override Task<BibleFormatEntity<string>> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleFormatEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleFormatEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleFormatEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleFormatEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed()
    {
        BibleFormatEntity<string> printFormat = new (Guid.NewGuid().ToString(), "Print", string.Empty);
        BibleFormatEntity<string> digitalFormat = new(Guid.NewGuid().ToString(), "Digital", string.Empty);
        BibleFormatEntity<string> audioFormat = new(Guid.NewGuid().ToString(), "Audio", string.Empty);

        BibleFormatDictionary[printFormat.BibleFormatID] =    printFormat;
        BibleFormatDictionary[digitalFormat.BibleFormatID] =  digitalFormat;
        BibleFormatDictionary[audioFormat.BibleFormatID] =    audioFormat;
    }
}

