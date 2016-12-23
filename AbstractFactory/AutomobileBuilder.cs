using AbstractFactory.ProductInterfaces;

namespace AbstractFactory
{
    public static class AutomobileBuilder
    {
        public static IAutomobile BuildAutomobile(IFactory factory)
        {
            IAutomobile instance = factory.GetAutomobile();
            instance.Body = factory.Createbody();
            instance.Transmission = factory.CreateTransmission();
            instance.Suspension = factory.CreateSuspension();
            instance.Engine = factory.CreateEngine();
            return instance;
        }
    }
}