using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rimrock_api.Data;
using rimrock_api.Models.Interfaces;
using rimrock_api.Models.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace rimrock_api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public IHostingEnvironment Environment { get; }

        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
            // Brings in applicaiton configuration properties as key value pairs from external secrets file
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Reads environment for development vs production and assigns respective connection string.
            string connectionString = Environment.IsDevelopment()
                                            ? Configuration["ConnectionStrings:ProductionConnection"]
                                            : Configuration["ConnectionStrings:ProductionConnection"];

			services.AddDbContext<RimRockApiDbContext>(options =>
			options.UseSqlServer(connectionString));

            // Adds a scoped service of the type specified to the service specified
            services.AddScoped<IRetailer, RetailerService>();
            services.AddScoped<ILocation, LocationService>();
            services.AddScoped<IRegion, RegionService>();



            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(route => {

                route.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });

            // Documentation generation
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Visit https://rimrockapi.azurewebsites.net/swagger for interactive endpoint documentation.");
            });
        }
    }
}
