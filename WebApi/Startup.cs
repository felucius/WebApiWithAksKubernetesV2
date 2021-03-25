using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using WebApi.Data;

namespace WebApi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AppConnectionString")));

			// Swagger API documentation injection
			services.AddSwaggerGen(x =>
			{
				x.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "Website backend",
					Description = "Web API backend in ASP.NET Core",
					Contact = new OpenApiContact
					{
						Name = "Maxime de Lange",
						Email = "maxime.de.lange@outlook.com",
						Url = new Uri("https://www.linkedin.com/in/maxime-de-lange-867a4165/")
					}
				});
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// Swagger API documentation injection
			app.UseSwagger();
			app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "Maximes website backend"));

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
