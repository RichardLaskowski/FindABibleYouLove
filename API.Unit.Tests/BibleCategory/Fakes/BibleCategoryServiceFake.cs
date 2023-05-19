﻿using Application.Services.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace API.Unit.Tests.BibleCategory.Fakes;
internal class BibleCategoryServiceFake : IBibleCategoryService
{
    private readonly List<BibleCategoryContract> _bibleCategories;
    public BibleCategoryServiceFake(List<BibleCategoryContract> bibleCategoryContracts) 
    {
        _bibleCategories = bibleCategoryContracts;
    }

    public Task<BibleCategoryContract> CreateAsync(BibleCategoryContract contract) => throw new NotImplementedException();
    public Task DeleteAsync(string id) => throw new NotImplementedException();
    public Task UpdateAsync(string id, BibleCategoryContract contract) => throw new NotImplementedException();
    public Task<BibleCategoryContract> GetAsync(string id) => throw new NotImplementedException();
    public async Task<IEnumerable<BibleCategoryContract>> GetAllAsync() => await Task.Run(() => _bibleCategories);
}