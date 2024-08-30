namespace FactoryPattern;

public class Truck : IVehicle

{
    public void Drive()
    {
        ConsoleLogger.VehicleBuilder();
        Console.WriteLine("The truck is ready to go");
    }
}