using System.Security.Claims;
{
    {
        // INTRO
        Console.WriteLine("WELCOME TO THE DUNGEON, LOST TRAVELER");
        Console.WriteLine("WHAT IS YOUR CLASS?");
        Console.WriteLine("BARBARIAN, ARCHER, MAGE.");

        // Selecting Class..
        string classAnswer = Console.ReadLine().ToUpper();
        Role playerClass = ClassSelection(classAnswer);
        Console.WriteLine("YOUR CLASS IS: " + playerClass.GetName());
        ShowTravelChoices(playerClass);





    }
    static Role ClassSelection(string RoleAnswer)
    {
        Role playerRole;


        switch (RoleAnswer)
        {
            case "BARBARIAN":
                playerRole = new Role("BARBARIAN", 100, 100, 2000, new List<string> { "HEALTH POTION", "BERSERKER POTION" });
                break;
            case "ARCHER":
                playerRole = new Role("ARCHER", 150, 75, 1500, new List<string> { "THROWING KNIFE", "INVISIBILTY POTION" });
                break;
            case "MAGE":
                playerRole = new Role("MAGE", 200, 50, 1000, new List<string> { "MAGIC DUST", "FIRE SCROLL" });
                break;
            default:
                playerRole = new Role("BARBARIAN", 100, 100, 2000, new List<string> { "HEALTH POTION", "BERSERKER POTION" });
                break;
        }
        return playerRole;


    }
     void ShowTravelChoices(Role player)
    {
        string[] travelChoiceList = { "ENTER DUNGEON", "GO HOME" };

        Console.WriteLine("WHAT DO YOU DO NEXT?");
        Console.WriteLine($"{travelChoiceList[0]}, {travelChoiceList[1]}");

        string travelChoice = Console.ReadLine().ToUpper();

        while (travelChoice != "VALID")
            switch (travelChoice)
            {
                case "ENTER":
                case "ENTER DUNGEON":
                    EnterDungeon(player);
                    travelChoice = "VALID";
                    break;
                case "HOME":
                case "TOWN":
                case "GO HOME":
                    ReturnToTown();
                    travelChoice = "VALID";
                    break;
                default:
                    Console.WriteLine("CHOOSE A VALID OPTION, DUMBASS");
                    travelChoice = Console.ReadLine().ToUpper();
                    break;
            }

    }
    void InventoryChoices(Role player)
    {
        Console.WriteLine("CHOOSE WHAT ITEM TO USE");

        string inventoryChoice = Console.ReadLine().ToUpper();

        while (inventoryChoice != "VALID")
        {
            switch (inventoryChoice)
            {
                case "HEALTH POTION":
                    UseItem(inventoryChoice);
                    break;
                default:
                    Console.WriteLine("YOU DONT HAVE THAT ITEM");
                    break;
            }

        }
        inventoryChoice = Console.ReadLine().ToUpper();
    }
     void ShowInventory(Role player)
    {
        foreach (string item in player.GetInventory())
        {
            Console.WriteLine($"{item}");
        }
        InventoryChoices(player);
        ShowTravelChoices(player);
    }
    void GetInventory(Role player)
    {
        foreach (string item in player.GetInventory())
        {
            Console.WriteLine($"{item}");
        }
        InventoryChoices(player);
        ShowTravelChoices(player);
    }
    void EnterDungeon(Role player)
    {
        Console.WriteLine("ARE YOU SURE YOU WANT TO MAKE THIS MISTAKE YES/NO");
        string answer = Console.ReadLine().ToUpper();
        int turns = 0;
        while (turns <= 10 && answer == "YES")
        {
            Console.WriteLine("YOU FOOLISHLY DELVE DEEPER INTO THE DUNGEON");
            Event eventToGetThrough = Event.GetRandomEvent();
            Console.WriteLine("Looks like you're up against a " + eventToGetThrough.GetEnemyName());
            turns++;
            Console.WriteLine("WOULD YOU LIKE TO DELVE DEEPER?");
            answer = Console.ReadLine().ToUpper();
        }
       ShowTravelChoices(player);
    }
    void ReturnToTown()
    {
        Console.WriteLine("YOU COWARDLY TURN AWAY FROM DANGER AND RETURN TO TOWN");
        // Show Town choices
    }
    void UseItem(string inventoryChoice)
    {
        Console.WriteLine("USED " + inventoryChoice);

    }
}