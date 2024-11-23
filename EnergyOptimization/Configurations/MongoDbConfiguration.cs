using MongoDB.Driver;

namespace EnergyOptimization.Configurations
{
    public static class MongoDbConfiguration
    {
        public static void AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["MongoDbSettings:ConnectionString"];
            var databaseName = configuration["MongoDbSettings:DatabaseName"];

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            services.AddSingleton(database);
        }
    }
}

