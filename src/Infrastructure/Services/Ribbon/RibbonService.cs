using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;

using Domain.Common.Classes;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonService<TType> : BaseService<TType, RibbonEntity<TType>, RibbonContract<TType>>, IRibbonService<TType> where TType : class
{
    protected IRibbonRepository<TType> Repository => (IRibbonRepository<TType>)_repo;
    protected IRibbonMapper<TType> Mapper => (IRibbonMapper<TType>)_mapper;

    public RibbonService(IRibbonRepository<TType> repo, IRibbonMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<RibbonContract<TType>> CreateAsync(RibbonContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, RibbonContract<TType> contract) => throw new NotImplementedException();
    public override Task<RibbonContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}