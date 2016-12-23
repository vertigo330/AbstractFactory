using AbstractFactory.ProductInterfaces;
namespace AbstractFactory.ConcreteProducts
{
    public class PoloBody : IBody
    {

        public bool HasStereo
        {
            get;
            set;
        }

        public int NumberOfDoors
        {
            get; 
            set;
        }

        public double Weight
        {
            get; 
            set;
        }

        public Enums.BodyType Type
        {
            get; 
            set;
        }
    }
}