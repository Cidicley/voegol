using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestePratico.API.domain.Repositories;
using TestePratico.API.domain.Services;
using TestePratico.API.Persistence.Contexts;
using TestePratico.API.Persistence.Repositories;
using TestePratico.API.Services;

namespace TestePratico.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<AppDbContext>(options => {
                options.UseInMemoryDatabase("supermercado-api-in-memory");
            });

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ICategoriaService, CategoriaService>();

            services.AddScoped<IAirplaneRepository, AirplaneRepository>();
            services.AddScoped<IAirplaneService, AirplaneService>();

            services.AddScoped<IPassangerRepository, PassangerRepository>();
            services.AddScoped<IPassangerService, PassangerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
