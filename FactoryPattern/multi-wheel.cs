namespace FactoryPattern;

public class MultiWheel:IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a multi-wheel vehicle with 5 or more wheels!");
    }
}