/*using System;

internal class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int count in birdsPerDay)
        {
            if (count == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int count in birdsPerDay)
        {
            if (count >= 5) busyDays++;
        }
        return busyDays;
    }
    public static void Main()
    {
        // 1. función
        int[] semanaPasada = BirdCount.LastWeek();
        Console.WriteLine("Semana pasada: " + string.Join(", ", semanaPasada));

        // 2.rueba para esta semana (creamos nuestro objeto)
        int[] misPajaros = { 2, 5, 0, 7, 4, 1 }; 
        BirdCount contador = new BirdCount(misPajaros);

        // 3. Probamos Today()
        Console.WriteLine("Pájaros de hoy (último número): " + contador.Today());

        // 4. Probamos IncrementTodaysCount()
        contador.IncrementTodaysCount();
        Console.WriteLine("Pájaros de hoy después de sumar uno: " + contador.Today());

        // 5. Probamos HasDayWithoutBirds()
        Console.WriteLine("¿Tuvimos días con cero pájaros?: " + contador.HasDayWithoutBirds());

        // 6. Probamos CountForFirstDays()
        Console.WriteLine("Suma de los primeros 4 días: " + contador.CountForFirstDays(4));

        // 7. Probamos BusyDays()
        Console.WriteLine("Días con 5 pájaros o más: " + contador.BusyDays());
    }
  

}*/