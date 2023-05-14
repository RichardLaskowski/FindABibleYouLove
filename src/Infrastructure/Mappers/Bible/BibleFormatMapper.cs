using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleFormatMapper<TType> : BaseMapper<TType, BibleFormatEntity<TType>, BibleFormatContract<TType>>, IBibleFormatMapper<TType> where TType : class
{
    public override BibleFormatEntity<TType> Map(BibleFormatContract<TType> value) => throw new NotImplementedException();
    public override BibleFormatContract<TType> Map(BibleFormatEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<BibleFormatEntity<TType>> MapAll(IEnumerable<BibleFormatContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleFormatContract<TType>> MapAll(IEnumerable<BibleFormatEntity<TType>> values) => throw new NotImplementedException();
    public override Task<BibleFormatEntity<TType>> MapAsync(BibleFormatContract<TType> value) => throw new NotImplementedException();
    public override Task<BibleFormatContract<TType>> MapAsync(BibleFormatEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatEntity<TType>>> MapAllAsync(IEnumerable<BibleFormatContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleFormatContract<TType>>> MapAllAsync(IEnumerable<BibleFormatEntity<TType>> values) => throw new NotImplementedException();
}
