using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;
using Domain.Base.Classes.Services;
using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonService<TType> : StringBaseService<RibbonContract>, IRibbonService
{
    protected IRibbonRepository<TType> Repository => (IRibbonRepository<TType>)_repo;
    protected IRibbonMapper<TType> Mapper => (IRibbonMapper<TType>)_mapper;

    public RibbonService(IRibbonRepository<TType> repo, IRibbonMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<RibbonContract> CreateAsync(RibbonContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, RibbonContract contract) => throw new NotImplementedException();
    public override Task<RibbonContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonContract>> GetAllAsync() => throw new NotImplementedException();
}