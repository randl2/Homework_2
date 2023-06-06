using ForLessons;
using System.Text;

namespace Homework;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var deckThings = new DeckThings();

        List<string> deck = new List<string>() { "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "9", "9", "9", "9", "10",
        "10", "10", "10", "J", "J", "J", "J", "Q", "Q", "Q", "Q", "K", "K", "K", "K", "A", "A", "A", "A"};

        Console.WriteLine("Завдання 2\n");
        var newDeck = deckThings.MixDeck(deck);

        Console.WriteLine("Завдання 3\n");
        deckThings.FindPositionOfAce(newDeck);

        Console.WriteLine("Завдання 4\n");
        deckThings.RelocateAcesToBeginning(newDeck);

        Console.WriteLine("Завдання 5\n");
        var sortedDeck = deckThings.SortDeck(ref newDeck);

        Console.WriteLine("Завдання 6\n");
        TwentyOne twentyOne = new TwentyOne();
        twentyOne.Game();
    }
}