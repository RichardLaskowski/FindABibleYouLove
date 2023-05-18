using Application.Mappers.Cover;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;

public class CoverMapper : StringBaseMapper<CoverEntity, CoverContract>, ICoverMapper
{
    public override CoverEntity Map(CoverContract value) => throw new NotImplementedException();
    public override CoverContract Map(CoverEntity value) => throw new NotImplementedException();
    public override IEnumerable<CoverEntity> MapAll(IEnumerable<CoverContract> values) => throw new NotImplementedException();
    public override IEnumerable<CoverContract> MapAll(IEnumerable<CoverEntity> values) => throw new NotImplementedException();
    public override Task<CoverEntity> MapAsync(CoverContract value) => throw new NotImplementedException();
    public override Task<CoverContract> MapAsync(CoverEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverEntity>> MapAllAsync(IEnumerable<CoverContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverContract>> MapAllAsync(IEnumerable<CoverEntity> values) => throw new NotImplementedException();
}
