using System.Threading.Tasks;

using Application.Services.Bible;

using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleCategoryEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet(pattern: "bible/categories", handler: GetBibleCategoriesAsync);
    }

    #region Route Handlers

    internal async Task<IResult> GetBibleCategoriesAsync(IBibleCategoryService bibleCategoryService) => Results.Ok(value: await bibleCategoryService.GetAllAsync());
    //internal async Task CreateBibleCategoryAsync(IBibleCategoryService bibleCategoryService, BibleCategoryContract bibleCategoryContract) => Results.Ok(value: await bibleCategoryService.CreateAsync(bibleCategoryContract));

    #endregion

    public void DefineServices(IServiceCollection services) => services.AddSingleton(serviceType: typeof(IBibleCategoryService), implementationType: typeof(BibleCategoryService));

}
