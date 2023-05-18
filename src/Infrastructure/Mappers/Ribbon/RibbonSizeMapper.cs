using Application.Mappers.Ribbon;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonSizeMapper : StringBaseMapper<RibbonSizeEntity, RibbonSizeContract>, IRibbonSizeMapper
{
    public override RibbonSizeEntity Map(RibbonSizeContract value) => throw new NotImplementedException();
    public override RibbonSizeContract Map(RibbonSizeEntity value) => throw new NotImplementedException();
    public override IEnumerable<RibbonSizeEntity> MapAll(IEnumerable<RibbonSizeContract> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonSizeContract> MapAll(IEnumerable<RibbonSizeEntity> values) => throw new NotImplementedException();
    public override Task<RibbonSizeEntity> MapAsync(RibbonSizeContract value) => throw new NotImplementedException();
    public override Task<RibbonSizeContract> MapAsync(RibbonSizeEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeEntity>> MapAllAsync(IEnumerable<RibbonSizeContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeContract>> MapAllAsync(IEnumerable<RibbonSizeEntity> values) => throw new NotImplementedException();
}
