using Application.Mappers.Ribbon;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonDetailMapper : StringBaseMapper<RibbonDetailEntity, RibbonDetailContract>, IRibbonDetailMapper 
{
    public override RibbonDetailEntity Map(RibbonDetailContract value) => throw new NotImplementedException();
    public override RibbonDetailContract Map(RibbonDetailEntity value) => throw new NotImplementedException();
    public override IEnumerable<RibbonDetailEntity> MapAll(IEnumerable<RibbonDetailContract> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonDetailContract> MapAll(IEnumerable<RibbonDetailEntity> values) => throw new NotImplementedException();
    public override Task<RibbonDetailEntity> MapAsync(RibbonDetailContract value) => throw new NotImplementedException();
    public override Task<RibbonDetailContract> MapAsync(RibbonDetailEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonDetailEntity>> MapAllAsync(IEnumerable<RibbonDetailContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonDetailContract>> MapAllAsync(IEnumerable<RibbonDetailEntity> values) => throw new NotImplementedException();
}
