using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TwitterSupport.ApplicationService.Extensions;
using TwitterSupport.DependencyInjection;

namespace TwitterSupport.ApplicationService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvcCustom();
            services.RegisterServices();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseExceptionCustom(env);
            app.UseCorsCustom();
            app.UseMvcWithDefaultRoute();
        }
    }
}