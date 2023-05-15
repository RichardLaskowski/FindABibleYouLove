using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;

using Domain.Common.Classes;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonColorService<TType> : BaseService<TType, RibbonColorEntity<TType>, RibbonColorContract<TType>>, IRibbonColorService<TType> where TType : class
{
    protected IRibbonColorRepository<TType> Repository => (IRibbonColorRepository<TType>)_repo;
    protected IRibbonColorMapper<TType> Mapper => (IRibbonColorMapper<TType>)_mapper;

    public RibbonColorService(IRibbonColorRepository<TType> repo, IRibbonColorMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<RibbonColorContract<TType>> CreateAsync(RibbonColorContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, RibbonColorContract<TType> contract) => throw new NotImplementedException();
    public override Task<RibbonColorContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}