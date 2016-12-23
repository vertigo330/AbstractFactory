using AbstractFactory.ProductInterfaces;

namespace AbstractFactory
{
    public interface IFactory
    {
        IAutomobile GetAutomobile();
        IBody Createbody();
        ITransmission CreateTransmission();
        ISuspension CreateSuspension();
        IEngine CreateEngine();
    }
}