namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter count of your Vehicle");
            var count = int.Parse(Console.ReadLine());
            var vehicle = VehicleFactory.CreateVehicle(count);
            vehicle.Drive();
        }
    }
}
