using BackgroundJobTask.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BackgroundJobTask.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BackgroundJobTaskController : AbpControllerBase
{
    protected BackgroundJobTaskController()
    {
        LocalizationResource = typeof(BackgroundJobTaskResource);
    }
}
