namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter count of your Vehicle");
            // var count = int.Parse(Console.ReadLine());
            int option;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out option))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid option");
            }
            var vehicle = VehicleFactory.CreateVehicle(option);
            vehicle.Drive();
        }
    }
}
