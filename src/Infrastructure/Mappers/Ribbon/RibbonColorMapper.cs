using Application.Mappers.Ribbon;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonColorMapper<TType> : BaseMapper<TType, RibbonColorEntity<TType>, RibbonColorContract>, IRibbonColorMapper<TType> where TType : class
{
    public override RibbonColorEntity<TType> Map(RibbonColorContract value) => throw new NotImplementedException();
    public override RibbonColorContract Map(RibbonColorEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<RibbonColorEntity<TType>> MapAll(IEnumerable<RibbonColorContract> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonColorContract> MapAll(IEnumerable<RibbonColorEntity<TType>> values) => throw new NotImplementedException();
    public override Task<RibbonColorEntity<TType>> MapAsync(RibbonColorContract value) => throw new NotImplementedException();
    public override Task<RibbonColorContract> MapAsync(RibbonColorEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorEntity<TType>>> MapAllAsync(IEnumerable<RibbonColorContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorContract>> MapAllAsync(IEnumerable<RibbonColorEntity<TType>> values) => throw new NotImplementedException();
}
