using Application.Mappers.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleTranslationMapper<TType> : BaseMapper<TType, BibleTranslationEntity<TType>, BibleTranslationContract<TType>>, IBibleTranslationMapper<TType> where TType : class
{
    public override BibleTranslationEntity<TType> Map(BibleTranslationContract<TType> bibleTranslationContract) => new(
        bibleTranslationContract.BibleTranslationID,
        bibleTranslationContract.TranslationName,
        bibleTranslationContract.TranslationAbbreviation,
        bibleTranslationContract.TranslationDescription);

    public override BibleTranslationContract<TType> Map(BibleTranslationEntity<TType> bibleTranslationEntity) => new(
        bibleTranslationEntity.BibleTranslationID,
        bibleTranslationEntity.TranslationName,
        bibleTranslationEntity.TranslationAbbreviation,
        bibleTranslationEntity.TranslationDescription);

    public override IEnumerable<BibleTranslationEntity<TType>> MapAll(IEnumerable<BibleTranslationContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<BibleTranslationContract<TType>> MapAll(IEnumerable<BibleTranslationEntity<TType>> values) => throw new NotImplementedException();
    public override async Task<BibleTranslationEntity<TType>> MapAsync(BibleTranslationContract<TType> value) => await Task.Run(() => Map(value));
    public override async Task<BibleTranslationContract<TType>> MapAsync(BibleTranslationEntity<TType> value) => await Task.Run(() => Map(value));
    public override async Task<IEnumerable<BibleTranslationEntity<TType>>> MapAllAsync(IEnumerable<BibleTranslationContract<TType>> values)
    {
        IList<BibleTranslationEntity<TType>> bibleTranslationEntities = new List<BibleTranslationEntity<TType>>();

        foreach(BibleTranslationContract<TType> bibleTranslationContract in values)
        {
            bibleTranslationEntities.Add(await MapAsync(bibleTranslationContract));
        }

        return bibleTranslationEntities;
    }

    public override async Task<IEnumerable<BibleTranslationContract<TType>>> MapAllAsync(IEnumerable<BibleTranslationEntity<TType>> values)
    {
        IList<BibleTranslationContract<TType>> bibleTranslationContracts = new List<BibleTranslationContract<TType>>();

        foreach(var value in values)
        {
            bibleTranslationContracts.Add(await MapAsync(value));
        }

        return bibleTranslationContracts;
    }
}
