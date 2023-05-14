using Application.Mappers.Cover;

using Domain.Common.Classes;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;

public class CoverColorMapper<TType> : BaseMapper<TType, CoverColorEntity<TType>, CoverColorContract<TType>>, ICoverColorMapper<TType> where TType : class
{
    public override CoverColorEntity<TType> Map(CoverColorContract<TType> value) => throw new NotImplementedException();
    public override CoverColorContract<TType> Map(CoverColorEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<CoverColorEntity<TType>> MapAll(IEnumerable<CoverColorContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<CoverColorContract<TType>> MapAll(IEnumerable<CoverColorEntity<TType>> values) => throw new NotImplementedException();
    public override Task<CoverColorEntity<TType>> MapAsync(CoverColorContract<TType> value) => throw new NotImplementedException();
    public override Task<CoverColorContract<TType>> MapAsync(CoverColorEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorEntity<TType>>> MapAllAsync(IEnumerable<CoverColorContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverColorContract<TType>>> MapAllAsync(IEnumerable<CoverColorEntity<TType>> values) => throw new NotImplementedException();
}
