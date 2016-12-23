using AbstractFactory.ProductInterfaces;
namespace AbstractFactory.ConcreteProducts
{
    public class PoloEngine : IEngine
    {

        public int NumberOfCylenders
        {
            get; 
            set;
        }

        public double FuelTankSize
        {
            get; 
            set;
        }

        public double HorsePower
        {
            get;
            set;
        }

        public string IgnitionType
        {
            get; 
            set;
        }

        public double MilesPerGalon
        {
            get;
            set;
        }

        public double Weight
        {
            get; 
            set;
        }
    }
}