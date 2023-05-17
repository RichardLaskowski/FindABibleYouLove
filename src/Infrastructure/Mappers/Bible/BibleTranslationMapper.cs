using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleTranslationMapper<TType> : BaseMapper<TType, BibleTranslationEntity<TType>, BibleTranslationContract>, IBibleTranslationMapper<TType> where TType : class
{
    public override BibleTranslationEntity<TType> Map(BibleTranslationContract bibleTranslationContract) => new(
        bibleTranslationContract.BibleTranslationID,
        bibleTranslationContract.TranslationName,
        bibleTranslationContract.TranslationAbbreviation,
        bibleTranslationContract.TranslationDescription);

    public override BibleTranslationContract Map(BibleTranslationEntity<TType> bibleTranslationEntity) => new(
        bibleTranslationEntity.BibleTranslationID,
        bibleTranslationEntity.TranslationName,
        bibleTranslationEntity.TranslationAbbreviation,
        bibleTranslationEntity.TranslationDescription);

    public override IEnumerable<BibleTranslationEntity<TType>> MapAll(IEnumerable<BibleTranslationContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleTranslationContract> MapAll(IEnumerable<BibleTranslationEntity<TType>> values) => throw new NotImplementedException();
    public override async Task<BibleTranslationEntity<TType>> MapAsync(BibleTranslationContract value) => await Task.Run(() => Map(value));
    public override async Task<BibleTranslationContract> MapAsync(BibleTranslationEntity<TType> value) => await Task.Run(() => Map(value));
    public override async Task<IEnumerable<BibleTranslationEntity<TType>>> MapAllAsync(IEnumerable<BibleTranslationContract> values)
    {
        IList<BibleTranslationEntity<TType>> bibleTranslationEntities = new List<BibleTranslationEntity<TType>>();

        foreach(BibleTranslationContract bibleTranslationContract in values)
        {
            bibleTranslationEntities.Add(await MapAsync(bibleTranslationContract));
        }

        return bibleTranslationEntities;
    }

    public override async Task<IEnumerable<BibleTranslationContract>> MapAllAsync(IEnumerable<BibleTranslationEntity<TType>> values)
    {
        IList<BibleTranslationContract> bibleTranslationContracts = new List<BibleTranslationContract>();

        foreach(var value in values)
        {
            bibleTranslationContracts.Add(await MapAsync(value));
        }

        return bibleTranslationContracts;
    }
}
