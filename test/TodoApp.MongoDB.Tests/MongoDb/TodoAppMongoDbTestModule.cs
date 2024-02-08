using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace TodoApp.MongoDB;

[DependsOn(
    typeof(TodoAppApplicationTestModule),
    typeof(TodoAppMongoDbModule)
)]
public class TodoAppMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = TodoAppMongoDbFixture.GetRandomConnectionString();
        });
    }
}
