using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Application.api.Configuration;

public static partial class AppConfig
{
	public static IServiceCollection HookFrameworkFeatures(
		this IServiceCollection services)
	{
		services.AddControllers();
		services.AddSwaggerGen(c =>
		{
			c.SwaggerDoc("v1", BuildSwaggerInfo());
			var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
			var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
			c.IncludeXmlComments(xmlPath);
		});


		return services;
	}


	public static OpenApiInfo BuildSwaggerInfo()
	{
		return new OpenApiInfo { Title = "__appname__", Version = "v1" };
	}
}