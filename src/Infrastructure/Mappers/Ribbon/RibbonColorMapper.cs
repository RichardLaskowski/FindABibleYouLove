using Application.Mappers.Ribbon;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonColorMapper : StringBaseMapper<RibbonColorEntity, RibbonColorContract>, IRibbonColorMapper 
{
    public override RibbonColorEntity Map(RibbonColorContract value) => throw new NotImplementedException();
    public override RibbonColorContract Map(RibbonColorEntity value) => throw new NotImplementedException();
    public override IEnumerable<RibbonColorEntity> MapAll(IEnumerable<RibbonColorContract> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonColorContract> MapAll(IEnumerable<RibbonColorEntity> values) => throw new NotImplementedException();
    public override Task<RibbonColorEntity> MapAsync(RibbonColorContract value) => throw new NotImplementedException();
    public override Task<RibbonColorContract> MapAsync(RibbonColorEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorEntity>> MapAllAsync(IEnumerable<RibbonColorContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorContract>> MapAllAsync(IEnumerable<RibbonColorEntity> values) => throw new NotImplementedException();
}
