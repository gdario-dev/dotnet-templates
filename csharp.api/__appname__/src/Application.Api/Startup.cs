using Application.api.Configuration;
using Application.Builder.Injection.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.api
{

  public class Startup
  {

    #region DI
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {

      Configuration = configuration;

    }
    #endregion DI

    public void ConfigureServices(IServiceCollection services)
    {

      services
        .HookFrameworkFeatures()
        .BuildDependencyTree(Configuration);

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

      app.BuildApp(env);

    }

  }

}
