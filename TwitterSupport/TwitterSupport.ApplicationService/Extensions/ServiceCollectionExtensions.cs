using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace TwitterSupport.ApplicationService.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMvcCustom(this IServiceCollection services)
        {
            void Mvc(MvcOptions mvc)
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                mvc.Filters.Add(new AuthorizeFilter(policy));
            }

            void Json(MvcJsonOptions json)
            {
                json.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            }

            services.AddMvc(Mvc).AddJsonOptions(Json);
        }
    }
}