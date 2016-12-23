using AbstractFactory.Enums;

namespace AbstractFactory.ProductInterfaces
{
    public interface IBody
    {
        bool HasStereo { get; set; }

        int NumberOfDoors { get; set; }

        double Weight { get; set; }

        BodyType Type { get; set; }
    }
}