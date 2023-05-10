using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Endpoints.Common;

public interface IEndpoint
{
    void DefineEndpoints(WebApplication app);
    void DefineServices(IServiceCollection services);
}
