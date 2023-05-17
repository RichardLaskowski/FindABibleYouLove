using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleFormatMapper : BaseMapper<string, BibleFormatEntity<string>, BibleFormatContract>, IBibleFormatMapper<string> 
{
    public override BibleFormatEntity<string> Map(BibleFormatContract value) => throw new NotImplementedException();
    public override BibleFormatContract Map(BibleFormatEntity<string> value) => throw new NotImplementedException();
    public override IEnumerable<BibleFormatEntity<string>> MapAll(IEnumerable<BibleFormatContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleFormatContract> MapAll(IEnumerable<BibleFormatEntity<string>> values) => throw new NotImplementedException();
    public override Task<BibleFormatEntity<string>> MapAsync(BibleFormatContract value) => throw new NotImplementedException();
    public override Task<BibleFormatContract> MapAsync(BibleFormatEntity<string> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatEntity<string>>> MapAllAsync(IEnumerable<BibleFormatContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatContract>> MapAllAsync(IEnumerable<BibleFormatEntity<string>> values) => throw new NotImplementedException();
}
