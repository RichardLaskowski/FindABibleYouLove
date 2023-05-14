using Application.Mappers.Ribbon;

using Domain.Common.Classes;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Mappers.Ribbon;

public class RibbonDetailMapper<TType> : BaseMapper<TType, RibbonDetailEntity<TType>, RibbonDetailContract<TType>>, IRibbonDetailMapper<TType> where TType : class
{
    public override RibbonDetailEntity<TType> Map(RibbonDetailContract<TType> value) => throw new NotImplementedException();
    public override RibbonDetailContract<TType> Map(RibbonDetailEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<RibbonDetailEntity<TType>> MapAll(IEnumerable<RibbonDetailContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<RibbonDetailContract<TType>> MapAll(IEnumerable<RibbonDetailEntity<TType>> values) => throw new NotImplementedException();
    public override Task<RibbonDetailEntity<TType>> MapAsync(RibbonDetailContract<TType> value) => throw new NotImplementedException();
    public override Task<RibbonDetailContract<TType>> MapAsync(RibbonDetailEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonDetailEntity<TType>>> MapAllAsync(IEnumerable<RibbonDetailContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<RibbonDetailContract<TType>>> MapAllAsync(IEnumerable<RibbonDetailEntity<TType>> values) => throw new NotImplementedException();
}
