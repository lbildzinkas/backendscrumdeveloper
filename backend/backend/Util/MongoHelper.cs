using MongoDB.Driver;

namespace backend.Util
{
    public class MongoHelper
    {
        public static MongoClient GetMongoClient()
        {
            // ReSharper disable once ConvertToConstant.Local
            var connectionString = @"mongodb://lbildzinkas:senha123@ds011883.mlab.com:11883/backendscrumdev";
            return new MongoClient(connectionString);
        }
    }
}