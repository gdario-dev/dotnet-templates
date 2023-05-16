using Microsoft.Extensions.DependencyInjection;

namespace Application.Builder.Injection.Domain;

public static class Usecases
{
	public static IServiceCollection AddDomainUsecases(
		this IServiceCollection services)
	{
		return services;
	}
}