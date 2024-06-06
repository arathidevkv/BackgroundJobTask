using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BackgroundJobTask;

[Dependency(ReplaceServices = true)]
public class BackgroundJobTaskBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BackgroundJobTask";
}
