using TodoApp.Samples;
using Xunit;

namespace TodoApp.MongoDB.Domains;

[Collection(TodoAppTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<TodoAppMongoDbTestModule>
{

}
