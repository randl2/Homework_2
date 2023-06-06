namespace ForLessons;

class TwentyOne : DeckThings
{
    public void Game()
    {
        var deckTool = new DeckThings();
        bool isWorking = true;

        while (isWorking)
        {
            List<string> deck = new List<string>() { "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "9", "9", "9", "9", "10",
            "10", "10", "10", "J", "J", "J", "J", "Q", "Q", "Q", "Q", "K", "K", "K", "K", "A", "A", "A", "A"};

            List<string> myCards = new List<string>();
            List<string> computerCards = new List<string>();

            Console.WriteLine("Хто бажає отримати карти першим?\n1 - я\n2 - комп'ютер");
            FirstChoiceAgain:
            int firstChoice = Convert.ToInt32(Console.ReadLine());
            switch (firstChoice)
            {
                case 1:
                    GiveOneCard(deck, myCards);
                    GiveOneCard(deck, myCards);

                    Console.WriteLine("Ваші карти:");
                    foreach (string card in myCards)
                    {
                        Console.WriteLine($"{card}");
                    }

                    GiveOneCard(deck, computerCards);
                    GiveOneCard(deck, computerCards);

                    Console.WriteLine("Хочете взяти ще одну карту чи залишити як є?\n1 - взяти карту\n2 - не брати карт");
                    SecondChoiceAgain:
                    int secondChoice = Convert.ToInt32(Console.ReadLine());
                    switch (secondChoice)
                    {
                        case 1:
                            GiveOneCard(deck, myCards);
                            GiveOneCard(deck, computerCards);

                            Console.WriteLine("Вам і комп'ютеру дали по одній карті.");

                            Console.WriteLine("Ваші карти:");
                            foreach (string card in myCards)
                            {
                                Console.WriteLine($"{card}");
                            }

                            break;
                        case 2:
                            break;
                        default:
                            goto SecondChoiceAgain;
                    }

                    break;
                case 2:
                    GiveOneCard(deck, computerCards);
                    GiveOneCard(deck, computerCards);

                    GiveOneCard(deck, myCards);
                    GiveOneCard(deck, myCards);

                    Random rand = new Random();

                    int computerSecondChoice = rand.Next(1, 2);
                    Console.WriteLine("Комп'ютер обрав ");
                    switch (computerSecondChoice)
                    {
                        case 1:
                            Console.Write("взяти ще одну карту.");
                            GiveOneCard(deck, computerCards);
                            GiveOneCard(deck, myCards);
                            break;
                        case 2:
                            Console.Write("залишити як є.");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Введіть 1 або 2.");
                    goto FirstChoiceAgain;
            }

            int myCardsSum = 0;
            int computerCardsSum = 0;

            foreach (string card in myCards)
            {
                SummingUp(card, ref myCardsSum);
            }
            foreach (string card in computerCards)
            {
                SummingUp(card, ref computerCardsSum);
            }

            Console.WriteLine($"У вас {myCardsSum} очків\nУ комп'ютера {computerCardsSum} очків");

            bool userWon = false;

            Statistics.GamesPlayed += 1;
            if (myCardsSum == 22 || (myCardsSum > 21 && computerCardsSum > 21 && myCardsSum < computerCardsSum) || myCardsSum == 21 ||
                (myCardsSum > computerCardsSum && myCardsSum < 21 && computerCardsSum < 21))
            {
                userWon = true;
            }
            if (userWon)
            {
                Statistics.UserWon += 1;
                Console.WriteLine("Вітаю! Ви перемогли!");
            }
            else
            {
                Statistics.ComputerWon += 1;
                Console.WriteLine("На жаль, комп'ютер переміг.");
            }

            Console.WriteLine("1 - зіграти ще раз\n2 - подивитись статистику\n3 - закінчити грати");

            ThirdChoiceAgain:
            int thirdChoice = Convert.ToInt32(Console.ReadLine());
            switch (thirdChoice)
            {
                case 1:
                    break;
                case 2:
                    Statistics.ShowStatistics();
                    break;
                case 3:
                    isWorking = false;
                    break;
                default:
                    Console.WriteLine("Введіть або 1, або 2, або 3");
                    goto ThirdChoiceAgain;
            }
        }
        void GiveOneCard(List<string> deck, List<string> playerDeck)
        {
            Random rand = new Random();
            int randomCardId = rand.Next(0, deck.Count);

            playerDeck.Add(deck[randomCardId]);
            deck.RemoveAt(randomCardId);
        }
        void SummingUp(string card, ref int sum)
        {
            switch (card)
            {
                case "A":
                    sum += 11;
                    break;
                case "10":
                    sum += 10;
                    break;
                case "9":
                    sum += 9;
                    break;
                case "8":
                    sum += 8;
                    break;
                case "7":
                    sum += 7;
                    break;
                case "6":
                    sum += 6;
                    break;
                case "K":
                    sum += 4;
                    break;
                case "Q":
                    sum += 3;
                    break;
                case "J":
                    sum += 2;
                    break;
            }
        }
    }
}
