static class Encounter
{
    // metod för möte med fiende
    public static void HostileEncounter(bool encounter)
    {
        int roll = Misc.Roll();
        if (roll >= 0) // lägg till fiende class med olika mobs
        {
            Console.Clear();
            Console.WriteLine(@"
        
        <<<Gluuuuarrghhh!!!>>>

    Plötsligt kommer en person halvspringande emot dig.

    Han är klädd i en nerblodad forskarrock och ansiktet är fullkomligt

    täckt och förvidet av variga bölder och levrat blod...
            
            ");
        }
    }
    static void FriendlyEncounter()
    { }
}
