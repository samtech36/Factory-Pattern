namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberofTires;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of tires of the vehicle you want to create: ");
                
                input = int.TryParse(Console.ReadLine(), out numberofTires);
                
            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(numberofTires);
            vehicle.Drive();
        }
    }
}
