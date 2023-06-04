namespace ForLessons;

class DeckThings
{
    public List<string> MixDeck(List<string> deck)
    {
        Random random = new Random();
        var mixedDeck = new List<string>();
        int cardCount = deck.Count;

        for(int i = 0; i < cardCount; i++)
        {
            var randomCard = random.Next(0, deck.Count);
            mixedDeck.Add(deck[randomCard]);
            deck.Remove(deck[randomCard]);
        }

        ShowAllCards(mixedDeck);

        return mixedDeck;
    }
    public void FindPositionOfAce(List<string> deck)
    {
        for (int i = 0; i < deck.Count; i++)
        {
            if (deck[i] == "A")
            {
                Console.WriteLine($"Позиція туза: {i}");
            }
        }

        Console.WriteLine();
    }
    public void RelocateAcesToBeginning(List<string> deck)
    {
        int tempElement = 0;
        for(int i = 0; i < deck.Count;i++)
        {
            if (deck[i] == "A")
            {
                string temp = deck[tempElement];
                deck[tempElement] = deck[i];
                deck[i] = temp;

                tempElement++;
            }
        }

        ShowAllCards(deck);
    }
    public List<string> SortDeck(ref List<string> deck)
    {
        List<string> nums = new List<string>();
        List<string> tens = new List<string>();
        List<string> jacks = new List<string>();
        List<string> queens = new List<string>();
        List<string> kings = new List<string>();
        List<string> aces = new List<string>();
        for(int i = 0; i < deck.Count; i++)
        {
            switch (deck[i])
            {
                case "6":
                case "7":
                case "8":
                case "9":
                    nums.Add(deck[i]);
                    break;
                case "10":
                    tens.Add(deck[i]);
                    break;
                case "J":
                    jacks.Add(deck[i]);
                    break;
                case "Q":
                    queens.Add(deck[i]);
                    break;
                case "K":
                    kings.Add(deck[i]);
                    break;
                case "A":
                    aces.Add(deck[i]);
                    break;
            }

            deck.Remove(deck[i]);
            i -= 1;
        }

        nums.Sort();

        List<string> sortedList = nums.Concat(tens)
                                      .Concat(jacks)
                                      .Concat(queens)
                                      .Concat(kings)
                                      .Concat(aces)
                                      .ToList();

        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }

        return sortedList;
    }
    void ShowAllCards(List<string> deck)
    {
        foreach(string card in deck)
        {
            Console.WriteLine(card);
        }

        Console.WriteLine();
    }
}
