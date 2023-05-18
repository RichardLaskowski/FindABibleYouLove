using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;
using Domain.Base.Classes.Services;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonDetailService: StringBaseService<RibbonDetailContract, RibbonDetailEntity>, IRibbonDetailService
{
    protected IRibbonDetailRepository Repository => (IRibbonDetailRepository)_repo;
    protected IRibbonDetailMapper Mapper => (IRibbonDetailMapper)_mapper;

    public RibbonDetailService(IRibbonDetailRepository repo, IRibbonDetailMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<RibbonDetailContract> CreateAsync(RibbonDetailContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, RibbonDetailContract contract) => throw new NotImplementedException();
    public override Task<RibbonDetailContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonDetailContract>> GetAllAsync() => throw new NotImplementedException();
}