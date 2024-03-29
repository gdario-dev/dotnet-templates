using Application.api.Configuration;
using Application.Builder.Injection.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
#pragma warning disable CS1591

namespace Application.api;

public class Startup
{
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

	#region DI

	public IConfiguration Configuration { get; }

	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	#endregion DI
}