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
}