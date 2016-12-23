namespace AbstractFactory.ProductInterfaces
{
    public interface IAutomobile
    {
        IBody Body{get; set;}

        IEngine Engine{ get; set; }

        ITransmission Transmission { get; set; }

        ISuspension Suspension { get; set; }
    }
}