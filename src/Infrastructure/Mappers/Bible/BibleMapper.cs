using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleMapper : BaseMapper<string, BibleEntity<string>, BibleContract<string>>, IBibleMapper<string> 
{
    public override BibleEntity<string> Map(BibleContract<string> value) => throw new NotImplementedException();
    public override BibleContract<string> Map(BibleEntity<string> value) => throw new NotImplementedException();
    public override IEnumerable<BibleEntity<string>> MapAll(IEnumerable<BibleContract<string>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleContract<string>> MapAll(IEnumerable<BibleEntity<string>> values) => throw new NotImplementedException();
    public override Task<BibleEntity<string>> MapAsync(BibleContract<string> value) => throw new NotImplementedException();
    public override Task<BibleContract<string>> MapAsync(BibleEntity<string> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleEntity<string>>> MapAllAsync(IEnumerable<BibleContract<string>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleContract<string>>> MapAllAsync(IEnumerable<BibleEntity<string>> values) => throw new NotImplementedException();
}
