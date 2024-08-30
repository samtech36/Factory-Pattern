namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        ConsoleLogger.VehicleBuilder();
        Console.WriteLine("The motorcycle is ready to go!");
    }
}