using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;
using Domain.Base.Classes.Services;
using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverColorService : StringBaseService<CoverColorContract>, ICoverColorService 
{
    protected ICoverColorRepository<string> Repository => (ICoverColorRepository<string>)_repo;
    protected ICoverColorMapper<string> Mapper => (ICoverColorMapper<string>)_mapper;

    public CoverColorService(ICoverColorRepository<string> repo, ICoverColorMapper<string> mapper) : base(repo, mapper)
    {

    }

    public override Task<CoverColorContract> CreateAsync(CoverColorContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, CoverColorContract contract) => throw new NotImplementedException();
    public override Task<CoverColorContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorContract>> GetAllAsync() => throw new NotImplementedException();
}