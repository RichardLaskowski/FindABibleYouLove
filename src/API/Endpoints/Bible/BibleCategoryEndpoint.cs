using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using FindABibleYouLove.Contracts.Bible;

using Infrastructure.Mappers.Bible;
using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleCategoryEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet(pattern: "bible/categories", handler: GetBibleCategoriesAsync);
        app.MapPost(pattern: "bible/categories", handler: CreateBibleCategoryAsync);
    }

    #region Route Handlers

    internal async Task<IResult> GetBibleCategoriesAsync(IBibleCategoryService bibleCategoryService)
    {
        IEnumerable<BibleCategoryContract> bibleCategories = await bibleCategoryService.GetAllAsync(); 
        
        return bibleCategories.Any()
            ? TypedResults.Ok<IEnumerable<BibleCategoryContract>>(bibleCategories)
            : TypedResults.NoContent();
    }

    internal async Task<IResult> CreateBibleCategoryAsync([FromBody] BibleCategoryContract bibleCategoryContract, IBibleCategoryService bibleCategoryService)
    {
        BibleCategoryContract bibleCategory = await bibleCategoryService.CreateAsync(bibleCategoryContract); 
        
        return TypedResults.Created<BibleCategoryContract>(bibleCategory);
    }

    #endregion

    public void DefineServices(IServiceCollection services)
    {
        services.AddSingleton<IBibleCategoryService, BibleCategoryService>();
        services.AddSingleton<IBibleCategoryRepository, BibleCategoryFileRepository>();
        services.AddSingleton<IBibleCategoryMapper, BibleCategoryMapper>();
    }
}
