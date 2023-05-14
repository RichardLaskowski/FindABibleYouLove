using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleMapper<TType> : BaseMapper<TType, BibleEntity<TType>, BibleContract<TType>>, IBibleMapper<TType> where TType : class
{
    public override BibleEntity<TType> Map(BibleContract<TType> value) => throw new NotImplementedException();
    public override BibleContract<TType> Map(BibleEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<BibleEntity<TType>> MapAll(IEnumerable<BibleContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleContract<TType>> MapAll(IEnumerable<BibleEntity<TType>> values) => throw new NotImplementedException();
    public override Task<BibleEntity<TType>> MapAsync(BibleContract<TType> value) => throw new NotImplementedException();
    public override Task<BibleContract<TType>> MapAsync(BibleEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleEntity<TType>>> MapAllAsync(IEnumerable<BibleContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleContract<TType>>> MapAllAsync(IEnumerable<BibleEntity<TType>> values) => throw new NotImplementedException();
}
