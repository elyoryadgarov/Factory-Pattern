namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle CreateVehicle(int wheels)
    {
        switch (wheels)
        {
            case 2:
                return new Motorcycle();
            case 3:
                return new Motorcycle();
            case 4:
                return new Car();
            
            case int n when (n >= 4  && n <= 16):
                return new Commercial();
                
            default:
                Console.WriteLine("No such vehicle");
                return null;
        }
    }
}