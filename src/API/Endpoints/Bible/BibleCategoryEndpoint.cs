using System;
using System.Threading.Tasks;

using Application.Services.Bible;

using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleCategoryEndpoint : IEndpoint
{

    #region Route Handlers

    internal async Task<IResult> GetBibleCategoriesAsync(IBibleCategoryService<string> bibleCategoryService) => Results.Ok(value: await bibleCategoryService.GetAllAsync());
    internal async Task CreateBibleCategoryAsync(IBibleCategoryService<string> bibleCategoryService, BibleCategoryContract<string> bibleCategoryContract) => Results.Ok(value: await bibleCategoryService.CreateAsync(bibleCategoryContract));

    #endregion

    #region Public Methods

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet(pattern: "bible/categories", handler: GetBibleCategoriesAsync);
    }
    public void DefineServices(IServiceCollection services) => services.AddSingleton(serviceType: typeof(IBibleCategoryService<>), implementationType: typeof(BibleCategoryService));
    public void SeedResources()
    {
        BibleCategoryEntity<string> TextCategory                = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Text",             categoryDescription: string.Empty);
        BibleCategoryEntity<string> StudyCategory               = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Study",            categoryDescription: string.Empty);
        BibleCategoryEntity<string> JournalingCategory          = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Journaling",       categoryDescription: string.Empty);
        BibleCategoryEntity<string> ReadersCategory             = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Readers",          categoryDescription: string.Empty);
        BibleCategoryEntity<string> MinistryCategory            = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Ministry",         categoryDescription: string.Empty);
        BibleCategoryEntity<string> ChildrenAndTeensCategory    = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "ChildrenAndTeens", categoryDescription: string.Empty);
        BibleCategoryEntity<string> PremiumCategory             = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Premium",          categoryDescription: string.Empty);
        BibleCategoryEntity<string> DevotionalCategory          = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Devotional",       categoryDescription: string.Empty);
        BibleCategoryEntity<string> OtherCategory               = new BibleCategoryEntity<string>(bibleCategoryID: Guid.NewGuid().ToString(), categoryName: "Other",            categoryDescription: string.Empty);
    }

    #endregion

    #region Private Methods
}
    #endregion