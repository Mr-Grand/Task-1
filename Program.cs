namespace Task_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player1 = new("Danik", 24, "Archer");
        Player player2 = new("Khel", 40, "Warrior");
        Player player3 = new();
        player1.ShowInfo();
        player2.ShowInfo();
        player3.ShowInfo();
    }
}