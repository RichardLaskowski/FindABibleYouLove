using System.Threading.Tasks;

using Data.Repositories.Classes.Cover;
using Data.Repositories.Interfaces.Cover;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using WebAPI.Endpoints.Common;

namespace WebAPI.Endpoints;

public class CoversEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet(pattern: "covers/materials",  handler: GetCoverMaterialsAsync);
        app.MapGet(pattern: "covers/designs",    handler: GetCoverDesignsAsync);
        app.MapGet(pattern: "covers/colors",     handler: GetCoverColorsAsync);
    }

    #region Route Handlers
    
    internal async Task<IResult> GetCoverMaterialsAsync([FromServices] ICoverMaterialRepository<string> repo) => Results.Ok(await repo.GetCoverMaterialsAsync());
    internal async Task<IResult> GetCoverDesignsAsync([FromServices] ICoverDesignRepository<string> repo)     => Results.Ok(await repo.GetCoverDesignsAsync());
    internal async Task<IResult> GetCoverColorsAsync([FromServices] ICoverColorRepository<string> repo)       => Results.Ok(await repo.GetCoverColorsAsync());

    #endregion

    public void DefineServices(IServiceCollection services)
    {
        services.AddSingleton(serviceType: typeof(ICoverRepository<string>),            implementationType: typeof(CoverRepository));
        services.AddSingleton(serviceType: typeof(ICoverMaterialRepository<string>),    implementationType: typeof(CoverMaterialRepository));
        services.AddSingleton(serviceType: typeof(ICoverColorRepository<string>),       implementationType: typeof(CoverColorRepository));
        services.AddSingleton(serviceType: typeof(ICoverDesignRepository<string>),      implementationType: typeof(CoverDesignRepository));
    }
}