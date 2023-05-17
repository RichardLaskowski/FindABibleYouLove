using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleDictionaryRepository : DictionaryRepository<string, BibleEntity<string>> , IBibleRepository<string> 
{
    protected Dictionary<string, BibleEntity<string>> BibleDictionary => (Dictionary<string, BibleEntity<string>>)Dictionary;

    public override BibleEntity<string> Add(BibleEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity<string>> AddRange(IEnumerable<BibleEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity<string>> Find(Func<BibleEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleEntity<string>>> FindAsync(Func<BibleEntity<string>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleEntity<string> Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity<string>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleEntity<string>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<BibleEntity<string>> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleEntity<string> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleEntity<string>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed()
    {
        throw new NotImplementedException();
    }
}

