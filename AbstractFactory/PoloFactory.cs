using AbstractFactory.ConcreteProducts;
using AbstractFactory.Enums;
using AbstractFactory.ProductInterfaces;

namespace AbstractFactory
{
    public class PoloFactory : IFactory
    {

        public ProductInterfaces.IAutomobile GetAutomobile()
        {
            return new PoloAutomobile();
        }

        public ProductInterfaces.IBody Createbody()
        {
            return new PoloBody
                       {
                           HasStereo = false, 
                           NumberOfDoors = 4, 
                           Type = BodyType.Car, 
                           Weight = 1500
                       };
        }

        public ProductInterfaces.ITransmission CreateTransmission()
        {
            return new PoloTransmission
                       {
                           Drive = DriveType.FrontWheelDrive,
                           NumberOfAxels = 2,
                           NumberOfSpeeds = 5,
                           Type = TransmissionType.Manual,
                           Weight = 250
                       };
        }

        public ProductInterfaces.ISuspension CreateSuspension()
        {
            return new PoloSuspension
                       {
                           BreakType = "a polo break type",
                           SuspensionType = "a polo suspension",
                           TreadWidth = 5, 
                           Weight = 325,
                           WheelBase = 500
                       };
        }

        public ProductInterfaces.IEngine CreateEngine()
        {
            return new PoloEngine
                       {
                           FuelTankSize = 50,
                           HorsePower = 1500,
                           IgnitionType = "a polo ignition type",
                           MilesPerGalon = 30,
                           NumberOfCylenders = 6,
                           Weight = 650
                       };
        }
    }
}