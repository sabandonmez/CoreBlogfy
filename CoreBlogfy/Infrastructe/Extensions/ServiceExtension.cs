using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CoreBlogfy.Infrastructe.Extensions
{
	public static class ServiceExtension
	{
		public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<BlogfyContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("sqlconnection"),
				 b => b.MigrationsAssembly("DataAccessLayer"));
			});

		}
		public static void ConfigureRepositoryRegistration(this IServiceCollection services)
		{
			services.AddScoped<IRepositoryManager, RepositoryManager>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IBlogRepository, BlogRepository>();
		}
		public static void ConfigureServiceRegistration(this IServiceCollection services)
		{
			services.AddScoped<IServiceManager, ServiceManager>();
			services.AddScoped<ICategoryService, CategoryManager>();
			services.AddScoped<IBlogService, BlogManager>();
		}
		public static void ConfigureRouting(this IServiceCollection services)
		{
			services.AddRouting(options => {
				options.LowercaseUrls = true;
				options.AppendTrailingSlash = false;
			});
		}



	}
}
