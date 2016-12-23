using AbstractFactory.ProductInterfaces;
namespace AbstractFactory.ConcreteProducts
{
    public class PoloSuspension : ISuspension
    {

        public string BreakType
        {
            get;
            set;
        }

        public string SuspensionType
        {
            get; 
            set;
        }

        public double TreadWidth
        {
            get; 
            set;
        }

        public double Weight
        {
            get; 
            set;
        }

        public double WheelBase
        {
            get; 
            set;
        }
    }
}