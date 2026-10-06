/*static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent)
        {
            return !archerIsAwake;
        }
        else
        {
            return prisonerIsAwake && !archerIsAwake && !knightIsAwake;
        }
    }
    ! public static void Main()
    {
        // 1. Configuramos el escenario. Puedes cambiar estos true o false
        // para ver cómo cambian los resultados en la terminal.
        bool knightIsAwake = false;
        bool archerIsAwake = true;
        bool prisonerIsAwake = false;
        bool petDogIsPresent = false;

        Console.WriteLine("--- Escenario Actual ---");
        Console.WriteLine("Caballero despierto: " + knightIsAwake);
        Console.WriteLine("Arquero despierto: " + archerIsAwake);
        Console.WriteLine("Prisionero despierto: " + prisonerIsAwake);
        Console.WriteLine("Perro presente: " + petDogIsPresent);
        Console.WriteLine("------------------------\n");

        // 2.CanFastAttack

        bool puedeAtacar = CanFastAttack(knightIsAwake);
        Console.WriteLine("¿Podemos hacer un ataque rápido?: " + puedeAtacar);

        // 3. Probamos CanSpy
        // Necesita saber sobre el caballero, el arquero y el prisionero
        bool puedeEspiar = CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
        Console.WriteLine("¿Podemos espiar?: " + puedeEspiar);

        // 4. CanSignalPrisoner
        // Necesita al arquero y al prisionero
        bool puedeDarSenal = CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
        Console.WriteLine("¿Podemos hacerle señas al prisionero?: " + puedeDarSenal);

        // 5. CanFreePrisoner
        // Necesita a todos los personajes y al perro
        bool puedeLiberar = CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);
        Console.WriteLine("¿Podemos liberar al prisionero?: " + puedeLiberar);
    }
}*/
    