using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;
using Domain.Base.Classes.Services;
using FindABibleYouLove.Contracts.Ribbon;


namespace Infrastructure.Repositories.Ribbon;

public class RibbonSizeService : StringBaseService<RibbonSizeContract>, IRibbonSizeService
{
    protected IRibbonSizeRepository<TType> Repository => (IRibbonSizeRepository<TType>)_repo;
    protected IRibbonSizeMapper<TType> Mapper => (IRibbonSizeMapper<TType>)_mapper;

    public RibbonSizeService(IRibbonSizeRepository<TType> repo, IRibbonSizeMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<RibbonSizeContract> CreateAsync(RibbonSizeContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, RibbonSizeContract contract) => throw new NotImplementedException();
    public override Task<RibbonSizeContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeContract>> GetAllAsync() => throw new NotImplementedException();
}