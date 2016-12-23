using AbstractFactory.Enums;

namespace AbstractFactory.ProductInterfaces
{
    public interface ITransmission
    {
        DriveType Drive { get; set; }

        int NumberOfAxels { get; set; }

        int NumberOfSpeeds { get; set; }

        TransmissionType Type { get; set; }

        double Weight { get; set; }

    }
}