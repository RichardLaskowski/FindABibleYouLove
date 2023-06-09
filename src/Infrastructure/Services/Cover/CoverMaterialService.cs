﻿using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;

using Domain.Common.Classes;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverMaterialService<TType> : BaseService<TType, CoverMaterialEntity<TType>, CoverMaterialContract<TType>>, ICoverMaterialService<TType> where TType : class
{
    protected ICoverMaterialRepository<TType> Repository => (ICoverMaterialRepository<TType>)_repo;
    protected ICoverMaterialMapper<TType> Mapper => (ICoverMaterialMapper<TType>)_mapper;

    public CoverMaterialService(ICoverMaterialRepository<TType> repo, ICoverMaterialMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<CoverMaterialContract<TType>> CreateAsync(CoverMaterialContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, CoverMaterialContract<TType> contract) => throw new NotImplementedException();
    public override Task<CoverMaterialContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<CoverMaterialContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}