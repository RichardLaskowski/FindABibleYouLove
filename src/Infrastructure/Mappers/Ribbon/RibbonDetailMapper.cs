using Application.Mappers.Ribbon;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonDetailMapper<TType> : BaseMapper<TType, RibbonDetailEntity<TType>, RibbonDetailContract>, IRibbonDetailMapper<TType> where TType : class
{
    public override RibbonDetailEntity<TType> Map(RibbonDetailContract value) => throw new NotImplementedException();
    public override RibbonDetailContract Map(RibbonDetailEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<RibbonDetailEntity<TType>> MapAll(IEnumerable<RibbonDetailContract> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonDetailContract> MapAll(IEnumerable<RibbonDetailEntity<TType>> values) => throw new NotImplementedException();
    public override Task<RibbonDetailEntity<TType>> MapAsync(RibbonDetailContract value) => throw new NotImplementedException();
    public override Task<RibbonDetailContract> MapAsync(RibbonDetailEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonDetailEntity<TType>>> MapAllAsync(IEnumerable<RibbonDetailContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonDetailContract>> MapAllAsync(IEnumerable<RibbonDetailEntity<TType>> values) => throw new NotImplementedException();
}
