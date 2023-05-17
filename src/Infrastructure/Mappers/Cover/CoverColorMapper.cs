using Application.Mappers.Cover;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;

public class CoverColorMapper<TType> : BaseMapper<TType, CoverColorEntity<TType>, CoverColorContract>, ICoverColorMapper<TType> where TType : class
{
    public override CoverColorEntity<TType> Map(CoverColorContract value) => throw new NotImplementedException();
    public override CoverColorContract Map(CoverColorEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<CoverColorEntity<TType>> MapAll(IEnumerable<CoverColorContract> values) => throw new NotImplementedException();
    public override IEnumerable<CoverColorContract> MapAll(IEnumerable<CoverColorEntity<TType>> values) => throw new NotImplementedException();
    public override Task<CoverColorEntity<TType>> MapAsync(CoverColorContract value) => throw new NotImplementedException();
    public override Task<CoverColorContract> MapAsync(CoverColorEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorEntity<TType>>> MapAllAsync(IEnumerable<CoverColorContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorContract>> MapAllAsync(IEnumerable<CoverColorEntity<TType>> values) => throw new NotImplementedException();
}
