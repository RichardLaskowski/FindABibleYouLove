﻿using Application.Mappers.Ribbon;
using Application.Repositories.Ribbon;
using Application.Services.Ribbon;

using Domain.Common.Classes;
using Domain.Entities.Ribbon;

using FindABibleYouLove.Contracts.Ribbon;

namespace Infrastructure.Repositories.Ribbon;

public class RibbonDetailService<TType> : BaseService<TType, RibbonDetailEntity<TType>, RibbonDetailContract<TType>>, IRibbonDetailService<TType> where TType : class
{
    protected IRibbonDetailRepository<TType> Repository => (IRibbonDetailRepository<TType>)_repo;
    protected IRibbonDetailMapper<TType> Mapper => (IRibbonDetailMapper<TType>)_mapper;

    public RibbonDetailService(IRibbonDetailRepository<TType> repo, IRibbonDetailMapper<TType> mapper) : base(repo, mapper)
    {

    }
}