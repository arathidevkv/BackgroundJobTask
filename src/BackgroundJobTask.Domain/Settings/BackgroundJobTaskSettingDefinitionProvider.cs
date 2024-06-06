using Volo.Abp.Settings;

namespace BackgroundJobTask.Settings;

public class BackgroundJobTaskSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BackgroundJobTaskSettings.MySetting1));
    }
}
