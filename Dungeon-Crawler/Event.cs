using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Event
{
    static Random randomNum = new Random();

    private string name;
    private string reward;
    private int coins;
    private int damage;
    private int healthpoints;
    public Event(string name, string reward, int coins, int damage, int healthPoints)
    {
        this.name = name;
        this.reward = reward;
        this.coins = coins;
        this.damage = damage;
        this.healthpoints = healthPoints;

    }
    public static Event GetRandomEvent()
    {


        Event slime = new Event("Slime", "GOO", 10, GetRandomNumber(40, 60), 100);
        Event skeleton = new Event("Skeleton", "Bones", 20, GetRandomNumber(60, 100), 200);
        Event troll = new Event("Troll", "TrollCheese", 50, GetRandomNumber(150, 200), 350);
        Event dragon = new Event("Dragon", "Dragon scales", 500, GetRandomNumber(200, 350), 1000);
        Event[] allEnemies = { slime, skeleton, troll, dragon };

        Event randomEvent;
        int randomNumber = GetRandomNumber(0, allEnemies.Length + 1);

        switch (randomNumber)
        {
            case 0:
                randomEvent = slime;
                break;
            case 1:
                randomEvent = skeleton;
                break;
            case 2:
                randomEvent = troll;
                break;
            case 3:
                randomEvent = dragon;
                break;
            default:
                Console.WriteLine("GREAT, YOU CRASHED THE GAME SOMEHOW");
                randomEvent = slime;
                break;
        }
        return randomEvent;


        // for random dmg use random range from DMG/2 - DMG


    }
    public string GetEnemyName()
    {
        return this.name;
    }
    public static int GetRandomNumber(int minNum, int maxNum)
    {
        
        return randomNum.Next(minNum, maxNum);
    }
    public static int GetRandomNumber(int maxNum)
    {

        return randomNum.Next(maxNum);
    }

}