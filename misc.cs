static class Misc
{
    public static void Controls()
    {
        Console.Clear();
        Console.WriteLine(" _______________________________ ");
        Console.WriteLine("|                               |");
        Console.WriteLine("|           Kontroller:         |");
        Console.WriteLine("|_______________________________|");
        Console.WriteLine("|                               |");
        Console.WriteLine("|  \"W\" gå framåt                |");
        Console.WriteLine("|  \"S\" gå tillbaka              |");// tillbaka senare. Måste ev. vända rummet då:)
        Console.WriteLine("|  \"A\" gå vänster               |");
        Console.WriteLine("|  \"D\" gå höger                 |");
        Console.WriteLine("|_______________________________|");
        Console.WriteLine("|                               |");
        Console.WriteLine("|  \"K\" använd konsolpanel       |");
        Console.WriteLine("|  \"R\" Reka av rummet           |");
        Console.WriteLine("|_______________________________|");
        Console.WriteLine();
        //attackera, inspektera, vila(läka hp/sleep typ) med chans för nytt encounter)?, 
    }
    public static int Roll()
    {

        Random random = new Random();
        int roll = random.Next(1, 100);
        //Console.WriteLine($"Roll: {roll}");
        return roll;
    }
    static void ConsolePanel()
    {
        SlowPrint(@"Bakom den spruckna skärmen blinkar endast ett ord.

            <<<VARNING>>>
        
Dessvärre händer inget mer när du försöker komma in i konsolen...

", 1);
    }
    public static void SlowPrint(string text, int delay)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
    }
    public static void Move()
    {
        while (true)
        {
            Console.Write("\nVad vill du göra?");
            string? choice = Console.ReadLine().ToLower();
            if (choice == "c")
            {
                Controls(); //printar ut kontrollerna
            }
            else if (choice == "q")
            {
                break;
            }
            else if (choice == "w")
            {
                // Skapa ett nytt room
                NewRoom nextRoom = new NewRoom();

                // Anropa metoden CreateRoom
                nextRoom.CreateRoom();
            }
            else if (choice == "a")
            {
                // Skapa ett nytt room
                NewRoom nextRoom = new NewRoom();

                // Anropa metoden CreateRoom
                nextRoom.CreateRoom();
            }
            else if (choice == "d")
            {
                // Skapa ett nytt room
                NewRoom nextRoom = new NewRoom();

                // Anropa metoden CreateRoom
                nextRoom.CreateRoom();
            }
            else if (choice == "s") // gå tillbaks. lista förra rummet men invert?
            {
                Console.WriteLine("Du anar att något följer efter... Kanske bäst att inte vända tillbaks.");
            }
            else if (choice == "k")
            {
                ConsolePanel();
            }
            else
            {
                Console.WriteLine("Ogiltigt val!");
            }
        }
    }
}