using System;
using AbstractFactory.ProductInterfaces;
namespace AbstractFactory.ConcreteProducts
{
    public class PoloAutomobile : IAutomobile
    {

        public IBody Body
        {
            get;
            set;
        }

        public IEngine Engine
        {
            get; 
            set;
        }

        public ITransmission Transmission
        {
            get; 
            set;
        }

        public ISuspension Suspension
        {
            get; 
            set;
        }
    }
}