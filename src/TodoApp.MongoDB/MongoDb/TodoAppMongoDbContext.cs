using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace TodoApp.MongoDB;

[ConnectionStringName("Default")]
public class TodoAppMongoDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
    public IMongoCollection<TodoItem> TodoItems => Collection<TodoItem>();

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItem>(b =>
        {
            b.CollectionName = "TodoItems";
        });

    }
}
