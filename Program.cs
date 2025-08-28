

/*else
{
    Console.WriteLine("dead end");
    //break;
}*/
//SlowPrint("Du går en bit till.\n",10);
//bool isRunning = true;
//while(isRunning)
//{   

//}

class Program
{

    static void Main(string[] args)
    {   
        Console.Clear();
        // Intro
        Misc.SlowPrint(@"Du vaknar omtumlad upp i ett trångt utrymme.Ovanför dig öppnas långsamt en glaslucka.

Du tar dig sakta ut ur vad som liknar en cryo-pod och möts utav ett mörkt rum,

endast belyst utav ett flackande trasigt lysrör ovanför dig samt ett roterande gult ljus från en larmlampa ovanför rummets enda dörr.

Ovanför dörren lyser texten 'exit' med ett svagt grönt sken och till höger om dörren sitter en tryckplatta med samma grönt belysta text

'open' och 'unlocked'.

Runt om i rummet ser du ytterligare fyra tomma demolerade och blodstänkta cryo-poddar,

blodiga fotspår och något som ser ut som spår av något stort som släpats ut ur rummet,

längs med golvet som är fullkomligt nedsölat av blod och andra odefinierbara vätskor.
 
På väggen sitter en sprucken flimmrande konsolskärm bredvid dörren som leder ut ur rummet.

Utöver ett öronbedövande larmljud hör du ett varningsmeddelande med jämna intervaller.

'-Varning! Bege dig omgående till närmaste utrymningspod!

Haveriprotokoll inlett, Barriärskydd, skadat. Nivå kritiskt. Livsupphållande system.

Nivå kritisk. Upphör inom 55 minuter.' 

Det kanske är bäst att...

", 1); // ska konsollerna va viktiga för dörröppning osv?
        Console.WriteLine(); Thread.Sleep(100);
        Misc.SlowPrint("        <<<Get The Fuck Out>>>         \n", 50);
        Console.WriteLine(); Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(@"        <<<Get The Fuck Out>>> 
        
Den enda vägen ut tycks vara dörren rakt framför dig");

        Console.WriteLine();
        Console.WriteLine("\"C\" för att se spelets kontroller.");
        Console.WriteLine("\"Q\" för att avsluta spelet.");
        Console.WriteLine("\"Enter\" för att köra igång.");
        //string? choice = Console.ReadLine();

        // anropa första rummet? behov av metod?
        NewRoom firstRoom = new NewRoom();
        firstRoom.FirstRoom();
        Misc.Move(); // "kör igång styrningen"

    }
}
// public class Mob()
// {
//     //name;
//     //type;
//     //status;
//     //defense;
//     //resist
//     //attack;
//     //healthpoints
//     //hitbox
// }
