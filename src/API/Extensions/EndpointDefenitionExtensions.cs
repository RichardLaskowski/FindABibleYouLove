using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using WebAPI.Endpoints.Common;

namespace WebAPI.Extensions;

public static class EndpointExtensions
{
    public static void AddEndpointDefinitions(
        this IServiceCollection services, params Type[] scanMarkers)
    {
        List<IEndpoint> endpointDefinitions = new List<IEndpoint>();

        foreach (Type marker in scanMarkers)
        {
            endpointDefinitions.AddRange(
                collection: marker.Assembly.ExportedTypes
                .Where(predicate: x => typeof(IEndpoint).IsAssignableFrom(c: x) && !x.IsInterface)
                .Select(selector: Activator.CreateInstance).Cast<IEndpoint>()
            );
        }

        foreach (IEndpoint endpointDefinition in endpointDefinitions)
        {
            endpointDefinition.DefineServices(services);
        }

        services.AddSingleton(implementationInstance: endpointDefinitions as IReadOnlyCollection<IEndpoint>);
    }

    public static void UseEndPointDefinitions(this WebApplication app)
    {
        IReadOnlyCollection<IEndpoint>? definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndpoint>>();

        foreach (IEndpoint endpointDefinition in definitions)
        {
            endpointDefinition.DefineEndpoints(app);
        }
    }
}