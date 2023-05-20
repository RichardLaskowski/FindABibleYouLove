using System;
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
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleCategoryEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet(pattern: "bibles/categories", handler: GetAllBibleCategoriesAsync)
            .WithName("GetAllBibleCategories");

        app.MapPost(pattern: "bibles/categories", handler: CreateBibleCategoryAsync)
            .WithName("CreateBibleCategory");
    }

    #region Route Handlers

    internal async Task<IResult> GetAllBibleCategoriesAsync(IBibleCategoryService bibleCategoryService)
    {
        try
        {
            IEnumerable<BibleCategoryContract> bibleCategories = await bibleCategoryService.GetAllAsync();

            return bibleCategories.Any()
                ? TypedResults.Ok<IEnumerable<BibleCategoryContract>>(bibleCategories)
                : TypedResults.NotFound();
        }
        catch (Exception e)
        {
            return TypedResults.Problem(e.ToString());
        }
    }

    internal async Task<IResult> CreateBibleCategoryAsync(
        [FromBody] BibleCategoryContract bibleCategoryContract,
        IBibleCategoryService bibleCategoryService)
    {
        try
        {
            string bibleCategoryId = await bibleCategoryService.CreateAsync(bibleCategoryContract); 
        
            return TypedResults.Created($"bibles/categories/{bibleCategoryId})", bibleCategoryContract);
        }
        catch (Exception e)
        {
            return TypedResults.Problem(e.ToString());
        }
    }

    #endregion

    public void DefineServices(IServiceCollection services)
    {
        services.AddSingleton<IBibleCategoryService, BibleCategoryService>();
        services.AddSingleton<IBibleCategoryRepository, BibleCategoryFileRepository>();
        services.AddSingleton<IBibleCategoryMapper, BibleCategoryMapper>();
    }
}
