using Application.Mappers.Ribbon;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonMapper<TType> : BaseMapper<TType, RibbonEntity<TType>, RibbonContract>, IRibbonMapper<TType> where TType : class
{
    public override RibbonEntity<TType> Map(RibbonContract value) => throw new NotImplementedException();
    public override RibbonContract Map(RibbonEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<RibbonEntity<TType>> MapAll(IEnumerable<RibbonContract> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonContract> MapAll(IEnumerable<RibbonEntity<TType>> values) => throw new NotImplementedException();
    public override Task<RibbonEntity<TType>> MapAsync(RibbonContract value) => throw new NotImplementedException();
    public override Task<RibbonContract> MapAsync(RibbonEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonEntity<TType>>> MapAllAsync(IEnumerable<RibbonContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonContract>> MapAllAsync(IEnumerable<RibbonEntity<TType>> values) => throw new NotImplementedException();
}