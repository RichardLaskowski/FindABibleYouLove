using Application.Repositories.Bible;
using Domain.Entities.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleTranslationDictionaryRepository<TType> : DictionaryRepository<TType, BibleTranslationEntity<TType>>, IBibleTranslationRepository<TType> where TType : class
{
    protected Dictionary<TType, BibleTranslationEntity<TType>> BibleTranslationDictionary => (Dictionary<TType, BibleTranslationEntity<TType>>)Dictionary;

    public override BibleTranslationEntity<TType> Add(BibleTranslationEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleTranslationEntity<TType>> AddRange(IEnumerable<BibleTranslationEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleTranslationEntity<TType>> Find(Func<BibleTranslationEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleTranslationEntity<TType>>> FindAsync(Func<BibleTranslationEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override BibleTranslationEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<BibleTranslationEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<BibleTranslationEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<BibleTranslationEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(BibleTranslationEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<BibleTranslationEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(BibleTranslationEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<BibleTranslationEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

