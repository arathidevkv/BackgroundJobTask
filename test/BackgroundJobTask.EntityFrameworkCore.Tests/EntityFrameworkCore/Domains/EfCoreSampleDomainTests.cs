using BackgroundJobTask.Samples;
using Xunit;

namespace BackgroundJobTask.EntityFrameworkCore.Domains;

[Collection(BackgroundJobTaskTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BackgroundJobTaskEntityFrameworkCoreTestModule>
{

}
