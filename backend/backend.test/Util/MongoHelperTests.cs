using backend.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace backend.test.Util
{
    [TestClass]
    public class MongoHelperTests
    {
        [TestMethod]
        public void ConnectsToMongo()
        {
            var mongoDb = MongoHelper.GetMongoClient();
            var database = mongoDb.GetDatabase("backendscrumdev");
            Assert.IsNotNull(database);
        }

    }
}
