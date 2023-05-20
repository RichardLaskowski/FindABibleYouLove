using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;
using Domain.Base.Classes.Services;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverColorService : StringBaseService<CoverColorContract, CoverColorEntity>, ICoverColorService 
{
    protected ICoverColorRepository Repository => (ICoverColorRepository)_repo;
    protected ICoverColorMapper Mapper => (ICoverColorMapper)_mapper;

    public CoverColorService(ICoverColorRepository repo, ICoverColorMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<string> CreateAsync(CoverColorContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, CoverColorContract contract) => throw new NotImplementedException();
    public override Task<CoverColorContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorContract>> GetAllAsync() => throw new NotImplementedException();
}