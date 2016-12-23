namespace AbstractFactory.ProductInterfaces
{
    public interface ISuspension
    {
        string BreakType { get; set; }

        string SuspensionType { get; set; }

        double TreadWidth { get; set; }

        double Weight { get; set; }

        double WheelBase { get; set; }

    }
}