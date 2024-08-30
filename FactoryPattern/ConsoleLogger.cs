using System;
using System.Threading;

namespace FactoryPattern;

public class ConsoleLogger
{

    public static void VehicleBuilder()
    {
        Console.WriteLine("Gathering vehicle tools!");
        Thread.Sleep(1000);
        
        Console.WriteLine("Building vehicle!");
        Thread.Sleep(1000);
    }

}