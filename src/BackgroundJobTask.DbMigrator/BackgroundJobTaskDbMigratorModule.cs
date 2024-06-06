using BackgroundJobTask.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BackgroundJobTask.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BackgroundJobTaskEntityFrameworkCoreModule),
    typeof(BackgroundJobTaskApplicationContractsModule)
    )]
public class BackgroundJobTaskDbMigratorModule : AbpModule
{
}
