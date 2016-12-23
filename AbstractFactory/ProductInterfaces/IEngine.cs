namespace AbstractFactory.ProductInterfaces
{
    public interface IEngine
    {
        int NumberOfCylenders{ get; set;}

        double FuelTankSize { get; set; }

        double HorsePower { get; set; }

        string IgnitionType { get; set; }

        double MilesPerGalon { get; set; }

        double Weight { get; set; }
    }
}