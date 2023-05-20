using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;
using Domain.Base.Classes.Services;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverService : StringBaseService<CoverContract, CoverEntity>, ICoverService
{
    protected ICoverRepository Repository => (ICoverRepository)_repo;
    protected ICoverMapper Mapper => (ICoverMapper)_mapper;

    public CoverService(ICoverRepository repo, ICoverMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<string> CreateAsync(CoverContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, CoverContract contract) => throw new NotImplementedException();
    public override Task<CoverContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverContract>> GetAllAsync() => throw new NotImplementedException();
}