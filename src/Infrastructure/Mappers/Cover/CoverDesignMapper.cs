using Application.Mappers.Cover;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;
public class CoverDesignMapper : StringBaseMapper<CoverDesignEntity, CoverDesignContract>, ICoverDesignMapper
{
    public override CoverDesignEntity Map(CoverDesignContract value) => throw new NotImplementedException();
    public override CoverDesignContract Map(CoverDesignEntity value) => throw new NotImplementedException();
    public override IEnumerable<CoverDesignEntity> MapAll(IEnumerable<CoverDesignContract> values) => throw new NotImplementedException();
    public override IEnumerable<CoverDesignContract> MapAll(IEnumerable<CoverDesignEntity> values) => throw new NotImplementedException();
    public override Task<CoverDesignEntity> MapAsync(CoverDesignContract value) => throw new NotImplementedException();
    public override Task<CoverDesignContract> MapAsync(CoverDesignEntity value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverDesignEntity>> MapAllAsync(IEnumerable<CoverDesignContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverDesignContract>> MapAllAsync(IEnumerable<CoverDesignEntity> values) => throw new NotImplementedException();
}
