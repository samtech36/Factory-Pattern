namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numberofTires)
    {
        switch (numberofTires)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            case 6:
                return new Truck();
            default:
                return new Car();
            
        }
    }
    
}