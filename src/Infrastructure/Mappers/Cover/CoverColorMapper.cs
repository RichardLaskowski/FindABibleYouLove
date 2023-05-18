using Application.Mappers.Cover;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;

public class CoverColorMapper : StringBaseMapper<CoverColorEntity, CoverColorContract>, ICoverColorMapper
{
    public override CoverColorEntity Map(CoverColorContract value) => throw new NotImplementedException();
    public override CoverColorContract Map(CoverColorEntity value) => throw new NotImplementedException();
    public override IEnumerable<CoverColorEntity> MapAll(IEnumerable<CoverColorContract> values) => throw new NotImplementedException();
    public override IEnumerable<CoverColorContract> MapAll(IEnumerable<CoverColorEntity> values) => throw new NotImplementedException();
    public override Task<CoverColorEntity> MapAsync(CoverColorContract value) => throw new NotImplementedException();
    public override Task<CoverColorContract> MapAsync(CoverColorEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorEntity>> MapAllAsync(IEnumerable<CoverColorContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorContract>> MapAllAsync(IEnumerable<CoverColorEntity> values) => throw new NotImplementedException();
}
