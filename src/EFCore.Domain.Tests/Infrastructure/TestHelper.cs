using EFCore.Domain.Migrations;
using EFCore.Domain.PeopleManagement.Data;
using EFCore.Domain.VehicleManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCore.Domain.Tests.Infrastructure;

internal class TestHelper
{
    public static MigrationContext GetMigrationContext()
    {
        var options = new DbContextOptionsBuilder<MigrationContext>()
                            .UseSqlServer(GetConnectionString());
        return new MigrationContext(options.Options);
    }
    public static T? GetContext<T>() where T : DbContext
    {
        if (typeof(T) == typeof(VehicleManagementContext))
        { 
            var options = new DbContextOptionsBuilder<VehicleManagementContext>()
                                .UseSqlServer(GetConnectionString());
            return new VehicleManagementContext(options.Options) as T;
        } 
        else if (typeof(T) == typeof(PeopleManagementContext))
        {
            var options = new DbContextOptionsBuilder<PeopleManagementContext>()
                                .UseSqlServer(GetConnectionString());
            return new PeopleManagementContext(options.Options) as T;
        }
        return null;
    }

    private static string GetConnectionString()
    {
        return new ConfigurationBuilder().AddJsonFile("appSettings.json").Build().GetConnectionString("SQL")!;
    }
}
