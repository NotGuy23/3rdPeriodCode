using System.Security;

class Character
{
    public string name;
    public int health;
    public int strength;
    
    public static void Player()
    {
        Character player = new Character();
        player.name = "Sheldon";
        player.health = 100;
        player.strength = 100;

        Character Player1 = new Character();
        Player1.name = "Aiden";
        Player1.health = 100;
        Player1.strength = 100;

        Console.WriteLine(player.name);
    } 
    Console.WriteLine(player.name)
}