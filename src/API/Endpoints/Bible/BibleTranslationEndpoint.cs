using System.Threading.Tasks;

using Application.Repositories.Bible;

using Infrastructure.Repositories.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Bible;

public class BibleTranslationEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app) => app.MapGet(pattern: "bible/translations", handler: GetBibleTranslationAsync);

    #region Route Handlers

    internal async Task<IResult> GetBibleTranslationAsync(IBibleTranslationRepository<string> repo) => Results.Ok(value: await repo.GetAllAsync());

    #endregion

    public void DefineServices(IServiceCollection services) => services.AddSingleton(serviceType: typeof(IBibleTranslationRepository<>), implementationType: typeof(BibleTranslationDictionaryRepository<>));
}
