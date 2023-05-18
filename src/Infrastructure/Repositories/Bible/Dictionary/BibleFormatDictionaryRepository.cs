using Application.Repositories.Bible;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFormatDictionaryRepository : DictionaryBaseRepository<string, BibleFormatEntity>, IBibleFormatRepository 
{
    protected Dictionary<string, BibleFormatEntity> BibleFormatDictionary => (Dictionary<string, BibleFormatEntity>)Dictionary;

    public override BibleFormatEntity Add(BibleFormatEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity> AddRange(IEnumerable<BibleFormatEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity> Find(Func<BibleFormatEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleFormatEntity>> FindAsync(Func<BibleFormatEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleFormatEntity Get(string id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleFormatEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override async Task<IEnumerable<BibleFormatEntity>> GetAllAsync() => await Task.Run(() => BibleFormatDictionary.Values.ToList<BibleFormatEntity>());

    public override Task<BibleFormatEntity> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleFormatEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleFormatEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleFormatEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleFormatEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed()
    {
        BibleFormatEntity printFormat = new (Guid.NewGuid().ToString(), "Print", string.Empty);
        BibleFormatEntity digitalFormat = new(Guid.NewGuid().ToString(), "Digital", string.Empty);
        BibleFormatEntity audioFormat = new(Guid.NewGuid().ToString(), "Audio", string.Empty);

        BibleFormatDictionary[printFormat.BibleFormatID] =    printFormat;
        BibleFormatDictionary[digitalFormat.BibleFormatID] =  digitalFormat;
        BibleFormatDictionary[audioFormat.BibleFormatID] =    audioFormat;
    }
}

