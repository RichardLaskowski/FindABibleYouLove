using System.Threading.Tasks;

using Application.Repositories.Bible;
using Application.Services.Bible;

using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app) => app.MapGet(pattern: "bibles", handler: GetBiblesAsync);

    #region Route Handlers

    internal async Task<IResult> GetBiblesAsync(IBibleService service) => Results.Ok(value: await service.GetAllAsync());

    #endregion

    public void DefineServices(IServiceCollection services)
    => services.AddSingleton(serviceType: typeof(IBibleService), implementationType: typeof(BibleService));
}
