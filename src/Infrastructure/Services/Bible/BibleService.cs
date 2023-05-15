using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleService<TType> : BaseService<TType, BibleEntity<TType>, BibleContract<TType>> , IBibleService<TType> where TType : class
{
    protected IBibleRepository<TType> Repository => (IBibleRepository<TType>)_repo;
    protected IBibleMapper<TType> Mapper => (IBibleMapper<TType>)_mapper;

    public BibleService(IBibleRepository<TType> repo, IBibleMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleContract<TType>> CreateAsync(BibleContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, BibleContract<TType> contract) => throw new NotImplementedException();
    public override Task<BibleContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}