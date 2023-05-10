using System.Threading.Tasks;

using Data.Repositories.Classes.Bible;
using Data.Repositories.Interfaces.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using WebAPI.Endpoints.Common;

namespace WebAPI.Endpoints;

public class BiblesEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet(pattern: "bibles/categories", handler: GetBibleCategoriesAsync);
    }

    #region Route Handlers
        
    internal async Task<IResult> GetBibleCategoriesAsync(IBibleCategoryRepository<string> repo) => Results.Ok(value: await repo.GetBibleCategoriesAsync());

    #endregion
    
    public void DefineServices(IServiceCollection services)
    {
        services.AddSingleton(serviceType: typeof(IBibleRepository<string>), implementationType: typeof(BibleRepository));
        services.AddSingleton(serviceType: typeof(IBibleCategoryRepository<string>), implementationType: typeof(BibleCategoryRepository));
    }
}