using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;
using Domain.Base.Classes.Services;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverMaterialService : StringBaseService<CoverMaterialContract, CoverMaterialEntity>, ICoverMaterialService
{
    protected ICoverMaterialRepository Repository => (ICoverMaterialRepository)_repo;
    protected ICoverMaterialMapper Mapper => (ICoverMaterialMapper)_mapper;

    public CoverMaterialService(ICoverMaterialRepository repo, ICoverMaterialMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<CoverMaterialContract> CreateAsync(CoverMaterialContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, CoverMaterialContract contract) => throw new NotImplementedException();
    public override Task<CoverMaterialContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialContract>> GetAllAsync() => throw new NotImplementedException();
}