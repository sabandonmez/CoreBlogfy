using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace CoreBlogfy.Infrastructe.Extensions
{
	public static class ApplicationExtension
	{
		public static void UseConfigureAndCheckMigration(this IApplicationBuilder app)
		{
			BlogfyContext context = app
				.ApplicationServices
				.CreateScope()
				.ServiceProvider
				.GetRequiredService<BlogfyContext>();

			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}
		}


	}
}
