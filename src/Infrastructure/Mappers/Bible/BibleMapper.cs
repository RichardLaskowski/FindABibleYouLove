using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleMapper : BaseMapper<string, BibleEntity<string>, BibleContract>, IBibleMapper<string> 
{
    public override BibleEntity<string> Map(BibleContract value) => throw new NotImplementedException();
    public override BibleContract Map(BibleEntity<string> value) => throw new NotImplementedException();
    public override IEnumerable<BibleEntity<string>> MapAll(IEnumerable<BibleContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleContract> MapAll(IEnumerable<BibleEntity<string>> values) => throw new NotImplementedException();
    public override Task<BibleEntity<string>> MapAsync(BibleContract value) => throw new NotImplementedException();
    public override Task<BibleContract> MapAsync(BibleEntity<string> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleEntity<string>>> MapAllAsync(IEnumerable<BibleContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleContract>> MapAllAsync(IEnumerable<BibleEntity<string>> values) => throw new NotImplementedException();
}
