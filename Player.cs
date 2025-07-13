namespace Task_1;

public enum PlayerClass
{
    Warrior,
    Mage,
    Rogue,
    Archer,
    NPC
}

public class Player
{
    public PlayerClass ClassName;
    public int Level { get; private set; }
    public string Name { get; private set; }

    public Player(string name, int level, PlayerClass className)
    {
        Name = name;
        Level = level;
        ClassName = className;
    }

    public Player()
    {
        Name = "Unknown";
        Level = 0;
        ClassName = PlayerClass.NPC;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nPlayer - {Name}\nLevel - {Level}\nClass - {ClassName}\n");
    }
}