using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;
using Domain.Base.Classes.Services;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverDesignService : StringBaseService<CoverDesignContract>, ICoverDesignService
{
    protected ICoverDesignRepository<TType> Repository => (ICoverDesignRepository<TType>)_repo;
    protected ICoverDesignMapper Mapper => (ICoverDesignMapper)_mapper;

    public CoverDesignService(ICoverDesignRepository<TType> repo, ICoverDesignMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<CoverDesignContract> CreateAsync(CoverDesignContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, CoverDesignContract contract) => throw new NotImplementedException();
    public override Task<CoverDesignContract> GetAsync(string id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverDesignContract>> GetAllAsync() => throw new NotImplementedException();
}