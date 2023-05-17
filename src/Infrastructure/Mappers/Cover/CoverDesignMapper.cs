using Application.Mappers.Cover;
using Domain.Base.Classes.Mappers;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;
public class CoverDesignMapper<TType> : BaseMapper<TType, CoverDesignEntity<TType>, CoverDesignContract>, ICoverDesignMapper<TType> where TType : class
{
    public override CoverDesignEntity<TType> Map(CoverDesignContract value) => throw new NotImplementedException();
    public override CoverDesignContract Map(CoverDesignEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<CoverDesignEntity<TType>> MapAll(IEnumerable<CoverDesignContract> values) => throw new NotImplementedException();
    public override IEnumerable<CoverDesignContract> MapAll(IEnumerable<CoverDesignEntity<TType>> values) => throw new NotImplementedException();
    public override Task<CoverDesignEntity<TType>> MapAsync(CoverDesignContract value) => throw new NotImplementedException();
    public override Task<CoverDesignContract> MapAsync(CoverDesignEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverDesignEntity<TType>>> MapAllAsync(IEnumerable<CoverDesignContract> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverDesignContract>> MapAllAsync(IEnumerable<CoverDesignEntity<TType>> values) => throw new NotImplementedException();
}
