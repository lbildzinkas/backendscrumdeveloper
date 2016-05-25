using backend.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace backend.test.Models
{
    [TestClass]
    public class AddsTests
    {
        [TestMethod]
        public void ShouldCreateAd()
        {
            var ads = new AdsModels();
            ads.Create(new Ads() { Name = "Teste", Category = "Massage", Description = "teste 123", Value = 5});
        }    
    }
}