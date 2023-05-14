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
}