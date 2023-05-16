using Application.Builder.Injection.Domain;
using Application.Builder.Injection.Infra;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Builder.Injection.Application;

public static class Application
{
	public static IServiceCollection BuildDependencyTree(
		this IServiceCollection services,
		IConfiguration config
	)
	{
		// services.AddHttpClient();

		services
			.AddDomainOptions(config)
			.AddDomainUsecases()
			.AddPersistenceProviders();


		return services;
	}
}