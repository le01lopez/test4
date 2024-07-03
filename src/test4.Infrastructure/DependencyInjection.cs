using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using test4.Application.Abstractions.Date;
using test4.Domain.Products;
using test4.Infrastructure.Date;
using test4.Infrastructure.Repositories;

namespace test4.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IDateTimeProvider, DateTimeProvider>();

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseInMemoryDatabase("InMemoryDatabase").UseSnakeCaseNamingConvention();
        });

        services.AddScoped<IProductRepository, ProductBaseRepository>();

        return services;
    }
}
