using System.Threading.Tasks;

using Application.Repositories.Bible;

using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app) => app.MapGet(pattern: "bibles", handler: GetBiblesAsync);

    #region Route Handlers

    internal async Task<IResult> GetBiblesAsync(IBibleRepository<string> repo) => Results.Ok(value: await repo.GetAllAsync());

    #endregion

    public void DefineServices(IServiceCollection services)
    => services.AddSingleton(serviceType: typeof(IBibleRepository<>), implementationType: typeof(BibleDictionaryRepository<>));
}
