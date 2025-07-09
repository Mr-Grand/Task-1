namespace Task_1;

public class Player
{
    public readonly string ClassName;
    public readonly int Lvl;
    public readonly string Name;

    public Player(string name, int lvl, string className)
    {
        Name = name;
        Lvl = lvl;
        ClassName = className;
    }

    public Player()
    {
        Name = "Unknown";
        Lvl = 0;
        ClassName = "Unknown";
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nPlayer - {Name}\nLevel - {Lvl}\nClass - {ClassName}\n");
    }
}