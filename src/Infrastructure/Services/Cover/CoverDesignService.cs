using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;

using Domain.Common.Classes;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverDesignService<TType> : BaseService<TType, CoverDesignEntity<TType>, CoverDesignContract<TType>>, ICoverDesignService<TType> where TType : class
{
    protected ICoverDesignRepository<TType> Repository => (ICoverDesignRepository<TType>)_repo;
    protected ICoverDesignMapper<TType> Mapper => (ICoverDesignMapper<TType>)_mapper;

    public CoverDesignService(ICoverDesignRepository<TType> repo, ICoverDesignMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<CoverDesignContract<TType>> CreateAsync(CoverDesignContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, CoverDesignContract<TType> contract) => throw new NotImplementedException();
    public override Task<CoverDesignContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverDesignContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}