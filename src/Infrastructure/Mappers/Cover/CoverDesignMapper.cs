using Application.Mappers.Cover;

using Domain.Common.Classes;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Mappers.Cover;
public class CoverDesignMapper<TType> : BaseMapper<TType, CoverDesignEntity<TType>, CoverDesignContract<TType>>, ICoverDesignMapper<TType> where TType : class
{
    public override CoverDesignEntity<TType> Map(CoverDesignContract<TType> value) => throw new NotImplementedException();
    public override CoverDesignContract<TType> Map(CoverDesignEntity<TType> value) => throw new NotImplementedException();
    public override IEnumerable<CoverDesignEntity<TType>> MapAll(IEnumerable<CoverDesignContract<TType>> values) => throw new NotImplementedException();
    public override IEnumerable<CoverDesignContract<TType>> MapAll(IEnumerable<CoverDesignEntity<TType>> values) => throw new NotImplementedException();
    public override Task<CoverDesignEntity<TType>> MapAsync(CoverDesignContract<TType> value) => throw new NotImplementedException();
    public override Task<CoverDesignContract<TType>> MapAsync(CoverDesignEntity<TType> value) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverDesignEntity<TType>>> MapAllAsync(IEnumerable<CoverDesignContract<TType>> values) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverDesignContract<TType>>> MapAllAsync(IEnumerable<CoverDesignEntity<TType>> values) => throw new NotImplementedException();
}
