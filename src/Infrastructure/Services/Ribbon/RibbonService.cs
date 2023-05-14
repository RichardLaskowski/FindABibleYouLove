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
}