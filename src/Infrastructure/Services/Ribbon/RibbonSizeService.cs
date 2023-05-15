using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;

using Domain.Common.Classes;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;


namespace Infrastructure.Repositories.Ribbon;

public class RibbonSizeService<TType> : BaseService<TType, RibbonSizeEntity<TType>, RibbonSizeContract<TType>>, IRibbonSizeService<TType> where TType : class
{
    protected IRibbonSizeRepository<TType> Repository => (IRibbonSizeRepository<TType>)_repo;
    protected IRibbonSizeMapper<TType> Mapper => (IRibbonSizeMapper<TType>)_mapper;

    public RibbonSizeService(IRibbonSizeRepository<TType> repo, IRibbonSizeMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<RibbonSizeContract<TType>> CreateAsync(RibbonSizeContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, RibbonSizeContract<TType> contract) => throw new NotImplementedException();
    public override Task<RibbonSizeContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}