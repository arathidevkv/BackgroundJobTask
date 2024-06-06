using BackgroundJobTask.Samples;
using Xunit;

namespace BackgroundJobTask.EntityFrameworkCore.Applications;

[Collection(BackgroundJobTaskTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BackgroundJobTaskEntityFrameworkCoreTestModule>
{

}
