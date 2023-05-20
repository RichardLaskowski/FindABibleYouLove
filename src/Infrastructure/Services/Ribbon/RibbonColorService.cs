using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;
using Domain.Base.Classes.Services;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonColorService : StringBaseService<RibbonColorContract, RibbonColorEntity>, IRibbonColorService
{
    protected IRibbonColorRepository Repository => (IRibbonColorRepository)_repo;
    protected IRibbonColorMapper Mapper => (IRibbonColorMapper)_mapper;

    public RibbonColorService(IRibbonColorRepository repo, IRibbonColorMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<string> CreateAsync(RibbonColorContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, RibbonColorContract contract) => throw new NotImplementedException();
    public override Task<RibbonColorContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorContract>> GetAllAsync() => throw new NotImplementedException();
}