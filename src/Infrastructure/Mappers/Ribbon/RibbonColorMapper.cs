using Application.Mappers.Ribbon;

using Domain.Common.Classes;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonColorMapper<TType> : BaseMapper<TType, RibbonColorEntity<TType>, RibbonColorContract<TType>>, IRibbonColorMapper<TType> where TType : class
{
    public override RibbonColorEntity<TType> Map(RibbonColorContract<TType> value) => throw new NotImplementedException();
    public override RibbonColorContract<TType> Map(RibbonColorEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<RibbonColorEntity<TType>> MapAll(IEnumerable<RibbonColorContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonColorContract<TType>> MapAll(IEnumerable<RibbonColorEntity<TType>> values) => throw new NotImplementedException();
    public override Task<RibbonColorEntity<TType>> MapAsync(RibbonColorContract<TType> value) => throw new NotImplementedException();
    public override Task<RibbonColorContract<TType>> MapAsync(RibbonColorEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorEntity<TType>>> MapAllAsync(IEnumerable<RibbonColorContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonColorContract<TType>>> MapAllAsync(IEnumerable<RibbonColorEntity<TType>> values) => throw new NotImplementedException();
}
