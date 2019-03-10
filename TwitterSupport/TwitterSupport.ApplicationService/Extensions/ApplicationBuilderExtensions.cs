﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using TwitterSupport.ApplicationService.Middleware;

namespace TwitterSupport.ApplicationService.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseCorsCustom(this IApplicationBuilder application)
        {
            void CorsPolicy(CorsPolicyBuilder corsPolicy)
            {
                corsPolicy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials();
            }

            application.UseCors(CorsPolicy);
        }

        public static void UseExceptionCustom(this IApplicationBuilder application, IHostingEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                application.UseDeveloperExceptionPage();
                application.UseDatabaseErrorPage();
            }

            application.UseExceptionMiddleware();
        }

        public static void UseExceptionMiddleware(this IApplicationBuilder application)
        {
            application.UseMiddleware<ExceptionMiddleware>();
        }
    }
}