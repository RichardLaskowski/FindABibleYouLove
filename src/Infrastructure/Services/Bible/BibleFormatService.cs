using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFormatService<TType> : BaseService<TType, BibleFormatEntity<TType>, BibleFormatContract<TType>>, IBibleFormatService<TType> where TType : class
{
    protected IBibleFormatRepository<TType> Repository => (IBibleFormatRepository<TType>)_repo;
    protected IBibleFormatMapper<TType> Mapper => (IBibleFormatMapper<TType>)_mapper;

    public BibleFormatService(IBibleFormatRepository<TType> repo, IBibleFormatMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleFormatContract<TType>> CreateAsync(BibleFormatContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, BibleFormatContract<TType> contract) => throw new NotImplementedException();
    public override Task<BibleFormatContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}