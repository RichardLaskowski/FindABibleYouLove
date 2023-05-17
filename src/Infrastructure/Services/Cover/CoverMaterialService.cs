using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;
using Domain.Base.Classes.Services;
using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverMaterialService : StringBaseService<CoverMaterialContract>, ICoverMaterialService
{
    protected ICoverMaterialRepository<TType> Repository => (ICoverMaterialRepository<TType>)_repo;
    protected ICoverMaterialMapper<TType> Mapper => (ICoverMaterialMapper<TType>)_mapper;

    public CoverMaterialService(ICoverMaterialRepository<TType> repo, ICoverMaterialMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<CoverMaterialContract> CreateAsync(CoverMaterialContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, CoverMaterialContract contract) => throw new NotImplementedException();
    public override Task<CoverMaterialContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialContract>> GetAllAsync() => throw new NotImplementedException();
}