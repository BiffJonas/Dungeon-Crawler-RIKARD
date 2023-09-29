using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;


public class Role 
{
    private string name;
    private int damage;
    private int defense;
    private int healthPoints;
    private List<string> inventory = new List<string>(2);

    public Role(string name, int damage, int defense, int healthPoints, List<string> inventory)
    {
        this.name = name;
        this.damage = damage;
        this.defense = defense;
        this.healthPoints = healthPoints;
        this.inventory = inventory;

    }
    public string GetName() { return this.name; }
    public int GetDamage() { return this.damage; }
    public int GetDefense() { return this.defense; }
    public int GetHealthPoints() { return this.healthPoints; }
    public List<string> GetInventory() {  return this.inventory; }
   
    public void ShowStats()
    {
        Console.WriteLine("STATS:");
        Console.WriteLine($"ATK: {this.GetDamage()}");
        Console.WriteLine($"DEFENSE: {this.GetDefense()}");
        Console.WriteLine($"HP: {this.GetHealthPoints()}");
    }
    




    

    public bool CheckIfItemExistsInPlayerInv(string chosenItem)
    {
        //string[] allItems = { "HEALTH POTION", "BERSERKER POTION", "FIRE SCROLL", "MAGIC DUST", "THROWING KNFIE", "INVISIBILITY POTION" };
        return this.inventory.Contains(chosenItem);
    }
    
}
