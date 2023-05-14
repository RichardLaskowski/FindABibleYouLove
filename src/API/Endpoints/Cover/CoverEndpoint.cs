using System.Threading.Tasks;

using Application.Repositories.Cover;

using Infrastructure.Repositories.Cover;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints.Cover;

public class CoverEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app) => app.MapGet(pattern: "covers", handler: GetCoversAsync);

    #region Route Handlers

    internal async Task<IResult> GetCoversAsync(ICoverRepository<string> repo) => Results.Ok(value: await repo.GetAllAsync());

    #endregion

    public void DefineServices(IServiceCollection services) => services.AddSingleton(serviceType: typeof(ICoverRepository<>), implementationType: typeof(CoverDictionaryRepository<>));
}