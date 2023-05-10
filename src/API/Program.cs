using Microsoft.AspNetCore.Builder;

using WebAPI.Endpoints;
using WebAPI.Extensions;

namespace API;

public static class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        #region Configure Services

        builder.Services.AddEndpointDefinitions(scanMarkers: typeof(CoversEndpoint));

        #endregion

        WebApplication app = builder.Build();

        #region Configure Pipeline

        app.UseEndPointDefinitions();

        #endregion Configure Pipeline

        app.Run();
    }
}
