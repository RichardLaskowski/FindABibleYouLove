using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;
using Domain.Base.Classes.Services;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;


namespace Infrastructure.Repositories.Ribbon;

public class RibbonSizeService : StringBaseService<RibbonSizeContract, RibbonSizeEntity>, IRibbonSizeService
{
    protected IRibbonSizeRepository Repository => (IRibbonSizeRepository)_repo;
    protected IRibbonSizeMapper Mapper => (IRibbonSizeMapper)_mapper;

    public RibbonSizeService(IRibbonSizeRepository repo, IRibbonSizeMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<string> CreateAsync(RibbonSizeContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, RibbonSizeContract contract) => throw new NotImplementedException();
    public override Task<RibbonSizeContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeContract>> GetAllAsync() => throw new NotImplementedException();
}