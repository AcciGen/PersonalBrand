using Microsoft.AspNetCore.Identity;
using PersonalBrand.Domain.Entities;
using PersonalBrand.Infrastructure.Persistance;

namespace PersonalBrand.UI.PersonalIdentity
{
    public static class IdentityExtensions
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<UserModel, IdentityRole>()
                    .AddEntityFrameworkStores<PersonalBrandDbContext>()
                    .AddDefaultTokenProviders();

            return services;
        }
    }
}
