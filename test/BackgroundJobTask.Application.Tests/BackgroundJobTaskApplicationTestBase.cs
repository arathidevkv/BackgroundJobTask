using Volo.Abp.Modularity;

namespace BackgroundJobTask;

public abstract class BackgroundJobTaskApplicationTestBase<TStartupModule> : BackgroundJobTaskTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
