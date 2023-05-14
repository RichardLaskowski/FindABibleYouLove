using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace API.Endpoints;

public interface IEndpoint
{
    void DefineEndpoints(WebApplication app);
    void DefineServices(IServiceCollection services);
}
