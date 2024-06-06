using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BackgroundJobTask.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BackgroundJobTaskDbContextFactory : IDesignTimeDbContextFactory<BackgroundJobTaskDbContext>
{
    public BackgroundJobTaskDbContext CreateDbContext(string[] args)
    {
        BackgroundJobTaskEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BackgroundJobTaskDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new BackgroundJobTaskDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BackgroundJobTask.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
