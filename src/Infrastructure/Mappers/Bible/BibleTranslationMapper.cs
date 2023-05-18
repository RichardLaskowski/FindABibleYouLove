using Application.Mappers.Bible;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Mappers.Bible;

public class BibleTranslationMapper : StringBaseMapper<BibleTranslationEntity, BibleTranslationContract>, IBibleTranslationMapper
{
    public override BibleTranslationEntity Map(BibleTranslationContract bibleTranslationContract) => new(
        bibleTranslationContract.BibleTranslationId,
        bibleTranslationContract.TranslationName,
        bibleTranslationContract.TranslationAbbreviation);

    public override BibleTranslationContract Map(BibleTranslationEntity bibleTranslationEntity) => new(
        bibleTranslationEntity.BibleTranslationId,
        bibleTranslationEntity.TranslationName,
        bibleTranslationEntity.TranslationAbbreviation);

    public override IEnumerable<BibleTranslationEntity> MapAll(IEnumerable<BibleTranslationContract> values) => throw new NotImplementedException();
    public override IEnumerable<BibleTranslationContract> MapAll(IEnumerable<BibleTranslationEntity> values) => throw new NotImplementedException();
    public override async Task<BibleTranslationEntity> MapAsync(BibleTranslationContract value) => await Task.Run(() => Map(value));
    public override async Task<BibleTranslationContract> MapAsync(BibleTranslationEntity value) => await Task.Run(() => Map(value));
    public override async Task<IEnumerable<BibleTranslationEntity>> MapAllAsync(IEnumerable<BibleTranslationContract> values)
    {
        IList<BibleTranslationEntity> bibleTranslationEntities = new List<BibleTranslationEntity>();

        foreach(BibleTranslationContract bibleTranslationContract in values)
        {
            bibleTranslationEntities.Add(await MapAsync(bibleTranslationContract));
        }

        return bibleTranslationEntities;
    }

    public override async Task<IEnumerable<BibleTranslationContract>> MapAllAsync(IEnumerable<BibleTranslationEntity> values)
    {
        IList<BibleTranslationContract> bibleTranslationContracts = new List<BibleTranslationContract>();

        foreach(var value in values)
        {
            bibleTranslationContracts.Add(await MapAsync(value));
        }

        return bibleTranslationContracts;
    }
}
