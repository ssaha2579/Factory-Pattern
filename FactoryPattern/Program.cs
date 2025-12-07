namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, how many wheels does your vehicle have?");
            var wheelCount = int.Parse(Console.ReadLine());
            
            var vechicle = VehicleFactory.CreateVehicle(wheelCount);
            vechicle.Drive();
                
        }
    }
}
