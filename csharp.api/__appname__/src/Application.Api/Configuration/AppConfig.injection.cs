using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Application.api.Configuration
{

  public static partial class AppConfig
  {

    public static IServiceCollection HookFrameworkFeatures(this IServiceCollection services)
    {

      services.AddControllers();
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", BuildSwaggerInfo());
      });

      return services;

    }


    public static OpenApiInfo BuildSwaggerInfo() =>
      new() { Title = "__appname__", Version = "v1" };

  }

}
