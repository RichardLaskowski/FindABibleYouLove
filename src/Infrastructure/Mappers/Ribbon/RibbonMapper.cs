using Application.Mappers.Ribbon;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonMapper : StringBaseMapper<RibbonEntity, RibbonContract>, IRibbonMapper 
{
    public override RibbonEntity Map(RibbonContract value) => throw new NotImplementedException();
    public override RibbonContract Map(RibbonEntity value) => throw new NotImplementedException();
    public override IEnumerable<RibbonEntity> MapAll(IEnumerable<RibbonContract> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonContract> MapAll(IEnumerable<RibbonEntity> values) => throw new NotImplementedException();
    public override Task<RibbonEntity> MapAsync(RibbonContract value) => throw new NotImplementedException();
    public override Task<RibbonContract> MapAsync(RibbonEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonEntity>> MapAllAsync(IEnumerable<RibbonContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonContract>> MapAllAsync(IEnumerable<RibbonEntity> values) => throw new NotImplementedException();
}