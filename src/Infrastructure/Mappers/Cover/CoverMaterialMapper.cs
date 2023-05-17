using Application.Mappers.Cover;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;
public class CoverMaterialMapper<TType> : BaseMapper<TType, CoverMaterialEntity<TType>, CoverMaterialContract>, ICoverMaterialMapper<TType> where TType : class
{
    public override CoverMaterialEntity<TType> Map(CoverMaterialContract value) => throw new NotImplementedException();
    public override CoverMaterialContract Map(CoverMaterialEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<CoverMaterialEntity<TType>> MapAll(IEnumerable<CoverMaterialContract> values) => throw new NotImplementedException();
    public override IEnumerable<CoverMaterialContract> MapAll(IEnumerable<CoverMaterialEntity<TType>> values) => throw new NotImplementedException();
    public override Task<CoverMaterialEntity<TType>> MapAsync(CoverMaterialContract value) => throw new NotImplementedException();
    public override Task<CoverMaterialContract> MapAsync(CoverMaterialEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialEntity<TType>>> MapAllAsync(IEnumerable<CoverMaterialContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialContract>> MapAllAsync(IEnumerable<CoverMaterialEntity<TType>> values) => throw new NotImplementedException();
}
