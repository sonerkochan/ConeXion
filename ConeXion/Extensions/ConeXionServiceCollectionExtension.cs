using ConeXion.Core.Contracts;
using ConeXion.Core.Services;
using ConeXion.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SportAreteServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
