using System.Threading.Tasks;

using Application.Repositories.Bible;
using Application.Services.Bible;

using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleFormatEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app) => app.MapGet(pattern: "bible/formats", handler: GetBibleFormatsAsync);

    #region Route Handlers

    internal async Task<IResult> GetBibleFormatsAsync(IBibleFormatRepository repo) => Results.Ok(value: await repo.GetAllAsync());

    #endregion

    public void DefineServices(IServiceCollection services) => services.AddSingleton(serviceType: typeof(IBibleFormatService), implementationType: typeof(BibleFormatService));
}
