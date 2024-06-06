using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BackgroundJobTask.Data;

/* This is used if database provider does't define
 * IBackgroundJobTaskDbSchemaMigrator implementation.
 */
public class NullBackgroundJobTaskDbSchemaMigrator : IBackgroundJobTaskDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
