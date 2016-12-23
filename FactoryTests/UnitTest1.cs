using AbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactory.ProductInterfaces;

namespace FactoryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanInstantiatePoloFromFactory()
        {
            IFactory poloFactory = new PoloFactory();
            IAutomobile polo = AutomobileBuilder.BuildAutomobile(poloFactory);
            Assert.IsNotNull(polo);
        }
    }
}
