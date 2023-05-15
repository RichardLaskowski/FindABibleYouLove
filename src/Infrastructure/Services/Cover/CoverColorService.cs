using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;

using Domain.Common.Classes;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverColorService<TType> : BaseService<TType, CoverColorEntity<TType>, CoverColorContract<TType>>, ICoverColorService<TType> where TType : class
{
    protected ICoverColorRepository<TType> Repository => (ICoverColorRepository<TType>)_repo;
    protected ICoverColorMapper<TType> Mapper => (ICoverColorMapper<TType>)_mapper;

    public CoverColorService(ICoverColorRepository<TType> repo, ICoverColorMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<CoverColorContract<TType>> CreateAsync(CoverColorContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, CoverColorContract<TType> contract) => throw new NotImplementedException();
    public override Task<CoverColorContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}