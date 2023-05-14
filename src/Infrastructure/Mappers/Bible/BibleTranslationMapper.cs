using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleTranslationMapper<TType> : BaseMapper<TType, BibleTranslationEntity<TType>, BibleTranslationContract<TType>>, IBibleTranslationMapper<TType> where TType : class
{
    public override BibleTranslationEntity<TType> Map(BibleTranslationContract<TType> value) => throw new NotImplementedException();
    public override BibleTranslationContract<TType> Map(BibleTranslationEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<BibleTranslationEntity<TType>> MapAll(IEnumerable<BibleTranslationContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleTranslationContract<TType>> MapAll(IEnumerable<BibleTranslationEntity<TType>> values) => throw new NotImplementedException();
    public override Task<BibleTranslationEntity<TType>> MapAsync(BibleTranslationContract<TType> value) => throw new NotImplementedException();
    public override Task<BibleTranslationContract<TType>> MapAsync(BibleTranslationEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleTranslationEntity<TType>>> MapAllAsync(IEnumerable<BibleTranslationContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleTranslationContract<TType>>> MapAllAsync(IEnumerable<BibleTranslationEntity<TType>> values) => throw new NotImplementedException();
}
