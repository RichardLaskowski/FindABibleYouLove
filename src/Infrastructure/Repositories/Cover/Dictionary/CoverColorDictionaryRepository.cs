using Application.Repositories.Cover;
using Domain.Base.Classes.Repositories;
using Domain.Entities.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverColorDictionaryRepository<TType> : DictionaryBaseRepository<TType, CoverColorEntity>, ICoverColorRepository<TType> where TType : class
{
    protected Dictionary<TType, CoverColorEntity> CoverColorDictionary => (Dictionary<TType, CoverColorEntity>)Dictionary;

    public override CoverColorEntity Add(CoverColorEntity entity)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverColorEntity> AddRange(IEnumerable<CoverColorEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverColorEntity> Find(Func<CoverColorEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverColorEntity>> FindAsync(Func<CoverColorEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public override CoverColorEntity Get(TType id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<CoverColorEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Task<IEnumerable<CoverColorEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CoverColorEntity> GetAsync(TType id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CoverColorEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void RemoveRange(IEnumerable<CoverColorEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Update(CoverColorEntity entity)
    {
        throw new NotImplementedException();
    }

    public override void UpdateRange(IEnumerable<CoverColorEntity> entities)
    {
        throw new NotImplementedException();
    }

    public override void Seed() => throw new NotImplementedException();
}

