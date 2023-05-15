using API.Endpoints.Bible;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using WebAPI.Extensions;

namespace API;

public static class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        #region Configure Services

        builder.Services.AddInfrastructureServices();
        builder.Services.AddEndpointDefinitions(scanMarkers: typeof(BibleEndpoint));

        #endregion

        WebApplication app = builder.Build();

        #region Configure Pipeline

        app.UseEndPointDefinitions();

        #endregion Configure Pipeline

        #region Seed Database

        #endregion

        app.Run();
    }
}
