using Application.Repositories.Cover;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverColorDictionaryRepository<TType> : DictionaryBaseRepository<TType, CoverColorEntity<TType>>, ICoverColorRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverColorEntity<TType>> CoverColorDictionary => (Dictionary<TType, CoverColorEntity<TType>>)Dictionary;

    public override CoverColorEntity<TType> Add(CoverColorEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverColorEntity<TType>> AddRange(IEnumerable<CoverColorEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverColorEntity<TType>> Find(Func<CoverColorEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverColorEntity<TType>>> FindAsync(Func<CoverColorEntity<TType>, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override CoverColorEntity<TType> Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverColorEntity<TType>> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverColorEntity<TType>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CoverColorEntity<TType>> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CoverColorEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<CoverColorEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(CoverColorEntity<TType> entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<CoverColorEntity<TType>> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

