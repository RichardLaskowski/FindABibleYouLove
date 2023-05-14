using System.Threading.Tasks;

using Application.Repositories.Ribbon;

using Infrastructure.Repositories.Ribbon;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Ribbon;

public class RibbonEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app) => app.MapGet(pattern: "ribbons", handler: GetRibbonsAsync);

    #region Route Handlers

    internal async Task<IResult> GetRibbonsAsync(IRibbonRepository<string> repo) => Results.Ok(value: await repo.GetAllAsync());

    #endregion

    public void DefineServices(IServiceCollection services) => services.AddSingleton(serviceType: typeof(IRibbonRepository<>), implementationType: typeof(RibbonDictionaryRepository<>));
}