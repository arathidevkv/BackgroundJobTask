using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BackgroundJobTask.Data;
using Volo.Abp.DependencyInjection;

namespace BackgroundJobTask.EntityFrameworkCore;

public class EntityFrameworkCoreBackgroundJobTaskDbSchemaMigrator
    : IBackgroundJobTaskDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBackgroundJobTaskDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BackgroundJobTaskDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BackgroundJobTaskDbContext>()
            .Database
            .MigrateAsync();
    }
}
