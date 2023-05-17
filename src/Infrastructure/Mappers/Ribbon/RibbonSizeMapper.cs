using Application.Mappers.Ribbon;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonSizeMapper<TType> : BaseMapper<TType, RibbonSizeEntity<TType>, RibbonSizeContract>, IRibbonSizeMapper<TType> where TType : class
{
    public override RibbonSizeEntity<TType> Map(RibbonSizeContract value) => throw new NotImplementedException();
    public override RibbonSizeContract Map(RibbonSizeEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<RibbonSizeEntity<TType>> MapAll(IEnumerable<RibbonSizeContract> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonSizeContract> MapAll(IEnumerable<RibbonSizeEntity<TType>> values) => throw new NotImplementedException();
    public override Task<RibbonSizeEntity<TType>> MapAsync(RibbonSizeContract value) => throw new NotImplementedException();
    public override Task<RibbonSizeContract> MapAsync(RibbonSizeEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeEntity<TType>>> MapAllAsync(IEnumerable<RibbonSizeContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeContract>> MapAllAsync(IEnumerable<RibbonSizeEntity<TType>> values) => throw new NotImplementedException();
}
