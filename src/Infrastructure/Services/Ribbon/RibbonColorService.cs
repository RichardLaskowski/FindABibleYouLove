using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;
using Domain.Base.Classes.Services;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonColorService : StringBaseService<RibbonColorContract>, IRibbonColorService
{
    protected IRibbonColorRepository<TType> Repository => (IRibbonColorRepository<TType>)_repo;
    protected IRibbonColorMapper<TType> Mapper => (IRibbonColorMapper<TType>)_mapper;

    public RibbonColorService(IRibbonColorRepository<TType> repo, IRibbonColorMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<RibbonColorContract> CreateAsync(RibbonColorContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, RibbonColorContract contract) => throw new NotImplementedException();
    public override Task<RibbonColorContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorContract>> GetAllAsync() => throw new NotImplementedException();
}