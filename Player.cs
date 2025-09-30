namespace Task_1;

public enum CharacterClass
{
    Warrior,
    Mage,
    Rogue,
    Archer
}

public class Player
{
    public CharacterClass ClassType { get; private set; }
    public int Level { get; private set; }
    public string Name { get; private set; }

    public Player(string name, int level, CharacterClass classType)
    {
        Name = name;
        Level = level;
        ClassType = classType;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nPlayer - {Name}\nLevel - {Level}\nClass - {ClassType}\n");
    }
}