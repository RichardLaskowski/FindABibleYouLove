﻿using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;
using Domain.Base.Classes.Services;
using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleFeatureService: StringBaseService<BibleFeatureContract>, IBibleFeatureService 
{
    protected IBibleFeatureRepository BibleFeatureRepo => (IBibleFeatureRepository)_repo;
    protected IBibleFeatureMapper BibleFeatureMapper => (IBibleFeatureMapper)_mapper;

    public BibleFeatureService(IBibleFeatureRepository repo, IBibleFeatureMapper mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleFeatureContract> CreateAsync(BibleFeatureContract contract) => throw new NotImplementedException();
    public override Task DeleteAsync(string id) => throw new NotImplementedException();
    public override Task UpdateAsync(string id, BibleFeatureContract contract) => throw new NotImplementedException();
    public override Task<BibleFeatureContract> GetAsync(string id) => throw new NotImplementedException();
    public override async Task<IEnumerable<BibleFeatureContract>> GetAllAsync() => await BibleFeatureMapper.MapAllAsync(await BibleFeatureRepo.GetAllAsync());
}