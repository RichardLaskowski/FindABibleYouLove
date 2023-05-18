using Application.Mappers.Cover;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;
public class CoverMaterialMapper : StringBaseMapper<CoverMaterialEntity, CoverMaterialContract>, ICoverMaterialMapper
{
    public override CoverMaterialEntity Map(CoverMaterialContract value) => throw new NotImplementedException();
    public override CoverMaterialContract Map(CoverMaterialEntity value) => throw new NotImplementedException();
    public override IEnumerable<CoverMaterialEntity> MapAll(IEnumerable<CoverMaterialContract> values) => throw new NotImplementedException();
    public override IEnumerable<CoverMaterialContract> MapAll(IEnumerable<CoverMaterialEntity> values) => throw new NotImplementedException();
    public override Task<CoverMaterialEntity> MapAsync(CoverMaterialContract value) => throw new NotImplementedException();
    public override Task<CoverMaterialContract> MapAsync(CoverMaterialEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialEntity>> MapAllAsync(IEnumerable<CoverMaterialContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialContract>> MapAllAsync(IEnumerable<CoverMaterialEntity> values) => throw new NotImplementedException();
}
