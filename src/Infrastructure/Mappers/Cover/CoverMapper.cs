using Application.Mappers.Cover;

using Domain.Common.Classes;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;

public class CoverMapper<TType> : BaseMapper<TType, CoverEntity<TType>, CoverContract<TType>>, ICoverMapper<TType> where TType : class
{
    public override CoverEntity<TType> Map(CoverContract<TType> value) => throw new NotImplementedException();
    public override CoverContract<TType> Map(CoverEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<CoverEntity<TType>> MapAll(IEnumerable<CoverContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<CoverContract<TType>> MapAll(IEnumerable<CoverEntity<TType>> values) => throw new NotImplementedException();
    public override Task<CoverEntity<TType>> MapAsync(CoverContract<TType> value) => throw new NotImplementedException();
    public override Task<CoverContract<TType>> MapAsync(CoverEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverEntity<TType>>> MapAllAsync(IEnumerable<CoverContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverContract<TType>>> MapAllAsync(IEnumerable<CoverEntity<TType>> values) => throw new NotImplementedException();
}
