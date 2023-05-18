using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleFormatMapper : StringBaseMapper<BibleFormatEntity, BibleFormatContract>, IBibleFormatMapper 
{
    public override BibleFormatEntity Map(BibleFormatContract value) => throw new NotImplementedException();
    public override BibleFormatContract Map(BibleFormatEntity value) => throw new NotImplementedException();
    public override IEnumerable<BibleFormatEntity> MapAll(IEnumerable<BibleFormatContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleFormatContract> MapAll(IEnumerable<BibleFormatEntity> values) => throw new NotImplementedException();
    public override Task<BibleFormatEntity> MapAsync(BibleFormatContract value) => throw new NotImplementedException();
    public override Task<BibleFormatContract> MapAsync(BibleFormatEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatEntity>> MapAllAsync(IEnumerable<BibleFormatContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatContract>> MapAllAsync(IEnumerable<BibleFormatEntity> values) => throw new NotImplementedException();
}
