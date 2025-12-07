namespace FactoryPattern;

public class multi_wheel:IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a multi-wheel vehicle with 5 or more wheels!");
    }
}