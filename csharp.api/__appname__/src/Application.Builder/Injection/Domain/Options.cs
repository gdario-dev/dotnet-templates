using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Builder.Injection.Domain;

public static class Options
{
	public static IServiceCollection AddDomainOptions(
		this IServiceCollection services,
		IConfiguration config
	)
	{
		return services;
	}
}