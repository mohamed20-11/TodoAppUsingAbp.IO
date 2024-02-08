using TodoApp.MongoDB;
using TodoApp.Samples;
using Xunit;

namespace TodoApp.MongoDb.Applications;

[Collection(TodoAppTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<TodoAppMongoDbTestModule>
{

}
