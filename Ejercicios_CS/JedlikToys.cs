/* using System;
class RemoteControlCar
{
    // Variables para guardar el estado del carro
    private int distance = 0;
    private int battery = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if (battery == 0)
        {
            return "Battery empty";
        }
        
        return $"Battery at {battery}%";
    }

    public void Drive()
    {
        if (battery > 0)
        {
            distance += 20;
            battery -= 1;
        }
    }
}

class JedlikToysProgram
{
    static void Main(string[] args)
    {
        // Comprar un carro
        RemoteControlCar car = RemoteControlCar.Buy();

        // Mostrar estado inicial
        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());

        // Conducir el carro
        car.Drive();
        car.Drive();
        car.Drive();

        // Mostrar estado después de conducir
        Console.WriteLine("\nDespués de conducir:");
        Console.WriteLine(car.DistanceDisplay());
        Console.WriteLine(car.BatteryDisplay());
    }
} */