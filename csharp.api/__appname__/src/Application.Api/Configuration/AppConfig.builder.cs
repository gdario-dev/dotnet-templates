using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Application.api.Configuration;

public static partial class AppConfig
{
	public static IApplicationBuilder BuildApp(
		this IApplicationBuilder app,
		IWebHostEnvironment env
	)
	{
		app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "__appname__ v1");
			})
			.UseSwagger();


		app.UseHttpsRedirection()
			.UseRouting();

		app.UseAuthorization();


		app.UseEndpoints(endpoints => { endpoints.MapControllers(); });


		return app;
	}
}