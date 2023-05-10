using Microsoft.AspNetCore.Mvc;

using WebAPI.Endpoints.Common;

namespace WebAPI.Endpoints;

public class RibbonsEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet(pattern: "ribbons/colors",    handler: GetRibbonColorsAsync);
        app.MapGet(pattern: "ribbons/sizes",     handler: GetRibbonSizesAsync); 
    }

    #region Route Handlers

    internal async Task<IResult> GetRibbonColorsAsync([FromServices] IRibbonColorRepository<string> repo) => Results.Ok(await repo.GetRibbonColorsAsync());
    internal async Task<IResult> GetRibbonSizesAsync([FromServices] IRibbonSizeRepository<string> repo) => Results.Ok(await repo.GetRibbonSizesAsync());

    #endregion

    public void DefineServices(IServiceCollection services)
    {
        services.AddSingleton(serviceType: typeof(IRibbonColorRepository<string>), implementationType: typeof(RibbonColorRepository));
        services.AddSingleton(serviceType: typeof(IRibbonSizeRepository<string>), implementationType: typeof(RibbonSizeRepository));
    }
}