using Application.Mappers.Cover;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;

public class CoverMapper<TType> : BaseMapper<TType, CoverEntity<TType>, CoverContract>, ICoverMapper<TType> where TType : class
{
    public override CoverEntity<TType> Map(CoverContract value) => throw new NotImplementedException();
    public override CoverContract Map(CoverEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<CoverEntity<TType>> MapAll(IEnumerable<CoverContract> values) => throw new NotImplementedException();
    public override IEnumerable<CoverContract> MapAll(IEnumerable<CoverEntity<TType>> values) => throw new NotImplementedException();
    public override Task<CoverEntity<TType>> MapAsync(CoverContract value) => throw new NotImplementedException();
    public override Task<CoverContract> MapAsync(CoverEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverEntity<TType>>> MapAllAsync(IEnumerable<CoverContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverContract>> MapAllAsync(IEnumerable<CoverEntity<TType>> values) => throw new NotImplementedException();
}
