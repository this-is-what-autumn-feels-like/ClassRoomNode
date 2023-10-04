using Database.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Database;

public static class ServiceCollectionExt
{
    public static void AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<DatabaseSettings>(configuration.GetSection(nameof(DatabaseSettings)));

        var dbSetting = configuration.GetRequiredSection(nameof(DatabaseSettings)).Get<DatabaseSettings>()!;

        services.AddDbContext<ClassRoomDbContext>(cfg => cfg.UseNpgsql(dbSetting.ConnectionStr));
    }
}