using System.Threading.Tasks;

using Application.Services.Bible;

using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleFeatureEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app) => app.MapGet(pattern: "bible/features", handler: GetBibleFeaturesAsync);

    #region Route Handlers

    internal async Task<IResult> GetBibleFeaturesAsync(IBibleFeatureService bibleFeatureService) => Results.Ok(value: await bibleFeatureService.GetAllAsync());

    #endregion

    public void DefineServices(IServiceCollection services) => services.AddSingleton(serviceType: typeof(IBibleFeatureService), implementationType: typeof(BibleFeatureService));
}