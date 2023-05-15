using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleFormatMapper : BaseMapper<string, BibleFormatEntity<string>, BibleFormatContract<string>>, IBibleFormatMapper<string> 
{
    public override BibleFormatEntity<string> Map(BibleFormatContract<string> value) => throw new NotImplementedException();
    public override BibleFormatContract<string> Map(BibleFormatEntity<string> value) => throw new NotImplementedException();
    public override IEnumerable<BibleFormatEntity<string>> MapAll(IEnumerable<BibleFormatContract<string>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleFormatContract<string>> MapAll(IEnumerable<BibleFormatEntity<string>> values) => throw new NotImplementedException();
    public override Task<BibleFormatEntity<string>> MapAsync(BibleFormatContract<string> value) => throw new NotImplementedException();
    public override Task<BibleFormatContract<string>> MapAsync(BibleFormatEntity<string> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatEntity<string>>> MapAllAsync(IEnumerable<BibleFormatContract<string>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatContract<string>>> MapAllAsync(IEnumerable<BibleFormatEntity<string>> values) => throw new NotImplementedException();
}
