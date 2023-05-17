using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;
using Domain.Base.Classes.Services;
using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverService : StringBaseService<CoverContract>, ICoverService
{
    protected ICoverRepository<TType> Repository => (ICoverRepository<TType>)_repo;
    protected ICoverMapper<TType> Mapper => (ICoverMapper<TType>)_mapper;

    public CoverService(ICoverRepository<TType> repo, ICoverMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<CoverContract> CreateAsync(CoverContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, CoverContract contract) => throw new NotImplementedException();
    public override Task<CoverContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverContract>> GetAllAsync() => throw new NotImplementedException();
}