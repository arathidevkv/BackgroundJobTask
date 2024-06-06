using Volo.Abp.Modularity;

namespace BackgroundJobTask;

/* Inherit from this class for your domain layer tests. */
public abstract class BackgroundJobTaskDomainTestBase<TStartupModule> : BackgroundJobTaskTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
