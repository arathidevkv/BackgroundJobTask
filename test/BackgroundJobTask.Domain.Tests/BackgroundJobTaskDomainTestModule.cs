using Volo.Abp.Modularity;

namespace BackgroundJobTask;

[DependsOn(
    typeof(BackgroundJobTaskDomainModule),
    typeof(BackgroundJobTaskTestBaseModule)
)]
public class BackgroundJobTaskDomainTestModule : AbpModule
{

}
