using Application.Mappers.Cover;

using Domain.Common.Classes;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;
public class CoverMaterialMapper<TType> : BaseMapper<TType, CoverMaterialEntity<TType>, CoverMaterialContract<TType>>, ICoverMaterialMapper<TType> where TType : class
{
    public override CoverMaterialEntity<TType> Map(CoverMaterialContract<TType> value) => throw new NotImplementedException();
    public override CoverMaterialContract<TType> Map(CoverMaterialEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<CoverMaterialEntity<TType>> MapAll(IEnumerable<CoverMaterialContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<CoverMaterialContract<TType>> MapAll(IEnumerable<CoverMaterialEntity<TType>> values) => throw new NotImplementedException();
    public override Task<CoverMaterialEntity<TType>> MapAsync(CoverMaterialContract<TType> value) => throw new NotImplementedException();
    public override Task<CoverMaterialContract<TType>> MapAsync(CoverMaterialEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialEntity<TType>>> MapAllAsync(IEnumerable<CoverMaterialContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialContract<TType>>> MapAllAsync(IEnumerable<CoverMaterialEntity<TType>> values) => throw new NotImplementedException();
}
