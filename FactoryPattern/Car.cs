namespace FactoryPattern;

public class Car : IVehicle
{
    public void Drive()
    {
        ConsoleLogger.VehicleBuilder();
        Console.WriteLine("The car is ready to go!");
    }
}