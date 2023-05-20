using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;
using Domain.Base.Classes.Services;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonService<TType> : StringBaseService<RibbonContract, RibbonEntity>, IRibbonService
{
    protected IRibbonRepository Repository => (IRibbonRepository)_repo;
    protected IRibbonMapper Mapper => (IRibbonMapper)_mapper;

    public RibbonService(IRibbonRepository repo, IRibbonMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<string> CreateAsync(RibbonContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, RibbonContract contract) => throw new NotImplementedException();
    public override Task<RibbonContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonContract>> GetAllAsync() => throw new NotImplementedException();
}