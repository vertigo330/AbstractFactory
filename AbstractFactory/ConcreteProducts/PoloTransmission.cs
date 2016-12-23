using AbstractFactory.ProductInterfaces;

namespace AbstractFactory.ConcreteProducts
{
    public class PoloTransmission : ITransmission
    {

        public Enums.DriveType Drive
        {
            get; 
            set;
        }

        public int NumberOfAxels
        {
            get; 
            set;
        }

        public int NumberOfSpeeds
        {
            get; 
            set;
        }

        public TransmissionType Type
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