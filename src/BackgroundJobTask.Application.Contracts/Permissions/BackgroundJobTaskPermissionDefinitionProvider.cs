using BackgroundJobTask.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BackgroundJobTask.Permissions;

public class BackgroundJobTaskPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BackgroundJobTaskPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BackgroundJobTaskPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BackgroundJobTaskResource>(name);
    }
}
