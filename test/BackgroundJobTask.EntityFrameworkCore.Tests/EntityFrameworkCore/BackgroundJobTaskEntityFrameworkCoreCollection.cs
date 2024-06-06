using Xunit;

namespace BackgroundJobTask.EntityFrameworkCore;

[CollectionDefinition(BackgroundJobTaskTestConsts.CollectionDefinitionName)]
public class BackgroundJobTaskEntityFrameworkCoreCollection : ICollectionFixture<BackgroundJobTaskEntityFrameworkCoreFixture>
{

}
