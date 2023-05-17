using System.Threading.Tasks;
using Application.Services.Bible;
using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleTranslationEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app) => app.MapGet(pattern: "bible/translations", handler: GetBibleTranslationsAsync);

    #region Route Handlers

    internal async Task<IResult> GetBibleTranslationsAsync(IBibleTranslationService bibleTranslationService) => Results.Ok(value: await bibleTranslationService.GetAllAsync());

    #endregion

    public void DefineServices(IServiceCollection services) => services.AddSingleton(serviceType: typeof(IBibleTranslationService), implementationType: typeof(BibleTranslationService));
}
