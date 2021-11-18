using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is like my 13th try
            //           Algorithm
            // A

            // - Make a new list of strings named deck
            // - Initialize the list of strings with 52 explicitly stated cards from example sections
            var deck = new List<string>() {
                "Ace of hearts",
                "2 of hearts",
                "3 of hearts",
                "4 of hearts",
                "5 of hearts",
                "6 of hearts",
                "7 of hearts",
                "8 of hearts",
                "9 of hearts",
                "10 of hearts",
                "Jack of hearts",
                "Queen of hearts",
                "King of hearts",
                "Ace of diamonds",
                "2 of diamonds",
                "3 of diamonds",
                "4 of diamonds",
                "5 of diamonds",
                "6 of diamonds",
                "7 of diamonds",
                "8 of diamonds",
                "9 of diamonds",
                "10 of diamonds",
                "Jack of diamonds",
                "Queen of diamonds",
                "King of diamonds",
                "Ace of spades",
                "2 of spades",
                "3 of spades",
                "4 of spades",
                "5 of spades",
                "6 of spades",
                "7 of spades",
                "8 of spades",
                "9 of spades",
                "10 of spades",
                "Jack of spades",
                "Queen of spades",
                "King of spades",
                "Ace of clubs",
                "2 of clubs",
                "3 of clubs",
                "4 of clubs",
                "5 of clubs",
                "6 of clubs",
                "7 of clubs",
                "8 of clubs",
                "9 of clubs",
                "10 of clubs",
                "Jack of clubs",
                "Queen of clubs",
                "King of clubs"
                };
            //   numberOfCards = length of our deck
            var numberOfCards = deck.Count;
            // - Shuffle the cards with Fisher Yates (paste algo here )
            //   for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                // leftIndex = random integer >= 0 and < rightIndex
                //   Now swap the values at rightIndex and leftIndex by doing this:
                //   leftCard = the value from deck[leftIndex]
                var leftCard = deck[leftIndex];
                //   rightCard = the value from deck[rightIndex]
                var rightCard = deck[rightIndex];
                //   deck[rightIndex] = leftCard
                deck[rightIndex] = leftCard;
                //   deck[leftIndex] = rightCard
                deck[leftIndex] = rightCard;
            }
            Console.WriteLine("You have reach a save point");

            // - first card = deck[0]
            var firstcardA = deck[0];
            // - second card = deck[1]
            var secondcardA = deck[1];
            // - print first and second card  
            Console.WriteLine("firstcard: " + firstcardA);
            Console.WriteLine("Secondcard: " + secondcardA);

            // Algorithm B 
            // - Make a new list of the fours suits
            var suits = new List<string>() { "clubs", "diamonds", "hearts", "spades" };
            // - Make of a list of 13 ranks and call this list ranks
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            // - Make a new list of strings namer 'deck'
            var deckB = new List<string>();
            // - Make a loop that goes through all the suits
            foreach (var suit in suits)
            {

                //   Make a loop that goes through all the 'ranks'
                //   add newly formed string to the end of the deck list - For Suit = Clubs
                foreach (var rank in ranks)
                {
                    var card = $"{rank} of {suit}";

                    deckB.Add(card);
                }
            }
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                // leftIndex = random integer >= 0 and < rightIndex
                //   Now swap the values at rightIndex and leftIndex by doing this:
                //   leftCard = the value from deck[leftIndex]
                var leftCard = deck[leftIndex];
                //   rightCard = the value from deck[rightIndex]
                var rightCard = deck[rightIndex];
                //   deck[rightIndex] = leftCard
                deck[rightIndex] = leftCard;
                //   deck[leftIndex] = rightCard
                deck[leftIndex] = rightCard;
            }

            // - first card = deck[0]
            var firstcardB = deck[0];
            // - second card = deck[1]
            var secondcardB = deck[1];
            // - print first and second card  
            Console.WriteLine("firstcard: " + firstcardB);
            Console.WriteLine("Secondcard: " + secondcardB);

            Console.WriteLine("You have reach a save point");

            //   add newly formed string to the end of the deck list - For Suit = Diamonds
            //   Make a loop that goes through all the ranks
            //   for each rank, make a new string of the form $"{rank} of diamonds "
            //   add newly formed string to the end of the deck list

            //         - For Suit = Spades
            //             Make a loop that goes through all the ranks
            //               for each rank, make a new string of the form $"{rank} of spades"
            //               add newly formed string to the end of the deck list

            //         - For Suit = Hearts
            //             Make a loop that goes through all the ranks
            //               for each rank, make a new string of the form $"{rank} of hearts"
            //               add newly formed string to the end of the deck list

            //   -Same as Algo A



















            // Create a deck of cards with 52 cards 
            // All cards should be represented as a string such as "Ace of Hearts"
            // There must be be four suits C, D, H, S
            // There are 13 ranks a, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, K, Q
            //  numberOfCards = length of our deck
            // // var suits = new string[] { "clubs", "diamonds", "hearts", "spades" };
            // // var ranks = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            // var deck = new string[] {"Ace of hearts", "2 of hearts", "3 of hearts", "4 of hearts", "5 of hearts", "6 of hearts", "7 of hearts", "8 of hearts", "9 of hearts", "10 of hearts",
            // "Jack of hearts", "Queen of hearts", "King of hearts", "Ace of diamonds", "2 of diamonds", "3 of diamonds", "4 of diamonds", "5 of diamonds", "6 of diamonds", "7 of diamonds", "8 of diamonds", "9 of diamonds",
            //  "10 of diamonds", "Jack of diamonds", "Queen of diamonds", "King of diamonds", "Ace of spades", "2 of spades", "3 of spades", "4 of spades", "5 of spades", "6 of spades", "7 of spades", "8 of spades", "9 of spades", "10 of spades",
            //  "Jack of spades", "Queen of spades", "King of spades", "Ace of clubs", "2 of clubs", "3 of clubs", "4 of clubs", "5 of clubs", "6 of clubs", "7 of clubs", "8 of clubs", "9 of clubs", "10 of clubs",
            // "Jack of clubs", "Queen of clubs", "King of clubs"};
            // foreach (var card in deck)
            // {
            //     Console.WriteLine(card);
            // }

            // numberOfCards = length of our deck
            // var numberOfCards = 52;
            //for rightIndex from numberOfCards - 1 down to 1 do:
            //var rightIndex = numberOfCards - 1;
            //leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
            // var numberOfCards = 52;
            // var rightIndex = numberOfCards - 1;
            // var randomNumberGenerator = new Random();
            // var randomNumber = randomNumberGenerator.Next(rightIndex);
            // Console.WriteLine(rightIndex);
            // var leftIndex = new Random();
            // Console.WriteLine(leftIndex.Next(leftindex));
            // Console.WriteLine(deck[rightcard]);
            // //leftCard = the value from deck[leftIndex]
            // var leftCard = leftIndex.Next(numberOfCards);
            // Console.WriteLine(deck[leftCard]);

            // var suits = new[] { "C", "D", "H", "S" };
            // var ranks = new[] { "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q" };

            // var newdeck = suits.Zip(ranks, (s , r) => new { suits = s, ranks = r });
            // foreach (var card in newdeck)A
            // {
            //     Console.WriteLine(card.suits + card.ranks);
            // }





            // After the deck is shuffled, and display the top two cards
            // After the deck creation, you should shuffle the deck


            //Now swap the values at rightIndex and leftIndex by doing this:

            //rightCard = the value from deck[rightIndex]
            //deck[rightIndex] = leftCard
            //deck[leftIndex] = rightCard
        }
    }
}
