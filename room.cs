public class Room
{
    public bool Enemy;
    public bool EventRoom;
    public bool WPath;
    public bool SPath;
    public bool APath;
    public bool DPath;

    //konstruktorn
    public Room(bool eventRoom, bool wPath, bool sPath, bool aPath, bool dPath)
    {
        EventRoom = eventRoom;//
        WPath = wPath;
        SPath = sPath;
        APath = aPath;
        DPath = dPath;
    }
    // work in progress
    public Room(bool enemy)
    {
        Enemy = enemy;
    }
}
// lista för rum
public class NewRoom
{   
    public List<Room> newRoom { get; set; }
    public NewRoom()
    {
        newRoom = new List<Room>(); 
    }
    public void FirstRoom() 
    {   
        AddRoom(false, true, false, false, false);
    }
    public void PreviousRoom()
    {

    }
    public void CurrentRoom() 
    {
        for (int i = 0 ; i < newRoom.Count ; i++)
        {   
            // jag vetefan:)
            bool wPath = newRoom[i].WPath;
            bool sPath = newRoom[i].SPath;
            bool aPath = newRoom[i].SPath;
            bool dPath = newRoom[i].DPath;
        }
    }
    public void EventRoom()
    {
        //lite olika alternativ 
    }
    public void CreateRoom() //behövs invärden?
    {   
        bool encounter = false;
        bool eventRoom = false;
        bool wPath = false;
        bool sPath = true;
        bool aPath = false;
        bool dPath = false;
    
        while(true)
        {   
            int roll = Misc.Roll();
            if (roll >= 75)
            {
                encounter = true;
                if (roll >= 85)
                    Encounter.HostileEncounter(encounter);
            }

            roll = Misc.Roll();
            if (roll >= 75)
            {
                eventRoom = true;
            }

            roll = Misc.Roll();
            if (roll >= 50)
            {
                wPath = true;
            }

            roll = Misc.Roll();
            if (roll >= 50)
            {
                aPath = true;
            }

            roll = Misc.Roll();
            if (roll >= 50)
            {
                dPath = true;
            }

            if (wPath == false && aPath == false && dPath == false)//ev ngn randommetod senare
            {
                wPath = true;
            }

            AddRoom(eventRoom, wPath, sPath, aPath, dPath);
            RoomDetails(encounter);
            break;
        }
    }  
    public void AddRoom(bool eventRoom, bool wPath, bool sPath, bool aPath, bool dPath)
    {   
        Room addRoom = new Room(eventRoom, wPath, sPath, aPath, dPath);
        newRoom.Add(addRoom); 
    }
    /// <summary>
    /// Genererar nästa rum.
    /// </summary>
    public void RoomDetails(bool enemy)
    {   
        Console.WriteLine("Strax ser du ",10);
        for(int i = 0; i < newRoom.Count; i++)
        {   
            if(newRoom[i].EventRoom == true)
            {
                EventRoom();
            }

            if(newRoom[i].APath == true)
            {
                 Console.Write("en gång åt vänster ",10);    
            }

            if(newRoom[i].DPath == true)
            {
                Console.Write("en gång åt höger ",10);
            }

            if(newRoom[i].WPath == true)
            {   
                if (newRoom[i].APath == false && newRoom[i].DPath == false)
                {
                    Console.Write("mer gång framåt. ");
                }

                if (newRoom[i].APath == true || newRoom[i].DPath == true)
                {
                    Console.Write("samt att gången fortsätter framåt. ",10);
                }
                else
                {
                    Console.Write("att gången fortsätter ett tag till rakt fram.");
                }
            }

            // if(newRoom[i].Enemy == true)
            // {
            //     Console.WriteLine($"<<<ENEMY>>>");
            //     Encounter(enemy);
            // } 
        }        
    }
}