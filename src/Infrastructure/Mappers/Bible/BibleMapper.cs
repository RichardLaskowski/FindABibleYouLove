using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleMapper : StringBaseMapper<BibleEntity, BibleContract>, IBibleMapper 
{
    public override BibleEntity Map(BibleContract value) => throw new NotImplementedException();
    public override BibleContract Map(BibleEntity value) => throw new NotImplementedException();
    public override IEnumerable<BibleEntity> MapAll(IEnumerable<BibleContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleContract> MapAll(IEnumerable<BibleEntity> values) => throw new NotImplementedException();
    public override Task<BibleEntity> MapAsync(BibleContract value) => throw new NotImplementedException();
    public override Task<BibleContract> MapAsync(BibleEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleEntity>> MapAllAsync(IEnumerable<BibleContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleContract>> MapAllAsync(IEnumerable<BibleEntity> values) => throw new NotImplementedException();
}
