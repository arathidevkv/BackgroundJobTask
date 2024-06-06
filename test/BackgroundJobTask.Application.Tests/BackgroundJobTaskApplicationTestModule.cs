using Volo.Abp.Modularity;

namespace BackgroundJobTask;

[DependsOn(
    typeof(BackgroundJobTaskApplicationModule),
    typeof(BackgroundJobTaskDomainTestModule)
)]
public class BackgroundJobTaskApplicationTestModule : AbpModule
{

}
