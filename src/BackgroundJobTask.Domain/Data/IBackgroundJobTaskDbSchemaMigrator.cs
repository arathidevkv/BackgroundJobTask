using System.Threading.Tasks;

namespace BackgroundJobTask.Data;

public interface IBackgroundJobTaskDbSchemaMigrator
{
    Task MigrateAsync();
}
