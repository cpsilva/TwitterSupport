using Microsoft.Extensions.DependencyInjection;
using System;
using TwitterSupport.Services.TweetService;

namespace TwitterSupport.DependencyInjection
{
    public static class Container
    {
        private static IServiceProvider _serviceProvider;

        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ITweetService, TweetService>();
            services.AddScoped<ITreatmentTweetService, TreatmentTweetService>();
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}