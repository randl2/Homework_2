namespace ForLessons;

static class Statistics
{
    static int gamesPlayed = 0;
    static int userWon = 0;
    static int computerWon = 0;
    public static int GamesPlayed { get; set; }
    public static int UserWon { get; set; }
    public static int ComputerWon { get; set; }
    public static void ShowStatistics()
    {
        Console.WriteLine($"СТАТИСТИКА\nІгор зіграно: {GamesPlayed}\nВиграші гравця: {UserWon}\nВиграші комп'ютера: {ComputerWon}");
    }
}
