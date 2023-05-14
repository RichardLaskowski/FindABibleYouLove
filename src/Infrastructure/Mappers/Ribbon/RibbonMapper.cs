using Application.Mappers.Ribbon;

using Domain.Common.Classes;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonMapper<TType> : BaseMapper<TType, RibbonEntity<TType>, RibbonContract<TType>>, IRibbonMapper<TType> where TType : class
{
    public override RibbonEntity<TType> Map(RibbonContract<TType> value) => throw new NotImplementedException();
    public override RibbonContract<TType> Map(RibbonEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<RibbonEntity<TType>> MapAll(IEnumerable<RibbonContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonContract<TType>> MapAll(IEnumerable<RibbonEntity<TType>> values) => throw new NotImplementedException();
    public override Task<RibbonEntity<TType>> MapAsync(RibbonContract<TType> value) => throw new NotImplementedException();
    public override Task<RibbonContract<TType>> MapAsync(RibbonEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonEntity<TType>>> MapAllAsync(IEnumerable<RibbonContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonContract<TType>>> MapAllAsync(IEnumerable<RibbonEntity<TType>> values) => throw new NotImplementedException();
}