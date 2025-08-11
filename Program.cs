namespace Task_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player1 = new("Danik", 24, CharacterClass.Archer);
        Player player2 = new("Khel", 40, CharacterClass.Warrior);
        player1.ShowInfo();
        player2.ShowInfo();
    }
}