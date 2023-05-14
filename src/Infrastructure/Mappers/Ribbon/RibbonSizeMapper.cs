using Application.Mappers.Ribbon;

using Domain.Common.Classes;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonSizeMapper<TType> : BaseMapper<TType, RibbonSizeEntity<TType>, RibbonSizeContract<TType>>, IRibbonSizeMapper<TType> where TType : class
{
    public override RibbonSizeEntity<TType> Map(RibbonSizeContract<TType> value) => throw new NotImplementedException();
    public override RibbonSizeContract<TType> Map(RibbonSizeEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<RibbonSizeEntity<TType>> MapAll(IEnumerable<RibbonSizeContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonSizeContract<TType>> MapAll(IEnumerable<RibbonSizeEntity<TType>> values) => throw new NotImplementedException();
    public override Task<RibbonSizeEntity<TType>> MapAsync(RibbonSizeContract<TType> value) => throw new NotImplementedException();
    public override Task<RibbonSizeContract<TType>> MapAsync(RibbonSizeEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeEntity<TType>>> MapAllAsync(IEnumerable<RibbonSizeContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonSizeContract<TType>>> MapAllAsync(IEnumerable<RibbonSizeEntity<TType>> values) => throw new NotImplementedException();
}
