using Application.Repositories.Bible;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleDictionaryRepository : DictionaryBaseRepository<string, BibleEntity> , IBibleRepository 
{
    protected Dictionary<string, BibleEntity> BibleDictionary => (Dictionary<string, BibleEntity>)Dictionary;

    public override BibleEntity Add(BibleEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity> AddRange(IEnumerable<BibleEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity> Find(Func<BibleEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleEntity>> FindAsync(Func<BibleEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleEntity Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<BibleEntity> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed()
    {
        throw new NotImplementedException();
    }
}

