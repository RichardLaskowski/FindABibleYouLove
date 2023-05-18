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

    internal async Task<IResult> GetBibleCategoriesAsync(IBibleCategoryService bibleCategoryService) => Results.Ok(value: await bibleCategoryService.GetAllAsync());
    internal async Task<IResult> CreateBibleCategoryAsync([FromBody] BibleCategoryContract bibleCategoryContract, IBibleCategoryService bibleCategoryService)
    {
        return Results.Ok(await bibleCategoryService.CreateAsync(bibleCategoryContract));
    }

    #endregion

    public void DefineServices(IServiceCollection services)
    {
        services.AddSingleton<IBibleCategoryService, BibleCategoryService>();
        services.AddSingleton<IBibleCategoryRepository, BibleCategoryFileRepository>();
        services.AddSingleton<IBibleCategoryMapper, BibleCategoryMapper>();
    }
}
