using System;
using System.Collections.Generic;
using System.Text;
using BackgroundJobTask.Localization;
using Volo.Abp.Application.Services;

namespace BackgroundJobTask;

/* Inherit your application services from this class.
 */
public abstract class BackgroundJobTaskAppService : ApplicationService
{
    protected BackgroundJobTaskAppService()
    {
        LocalizationResource = typeof(BackgroundJobTaskResource);
    }
}
