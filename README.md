# AllCardsOnDeckCS

PEDAC
Problem
Example
Data (data structure)
Algorithm
Code

problem
Requirements

    Your deck should contain 52 unique cards.
    All cards should be represented as a string such as "Ace of Hearts"
    There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
    There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".

Explorer Mode

    Once the program starts, you should create a new deck.
    After deck creation, you should shuffle the deck.
    After the deck is shuffled, display the top two cards.

Adventure Mode

    In addition to displaying the top two cards, also store these two "dealt" cards in a variable named playerHand. Consider what type of variable playerHand will have to be.
    Implement a way to two deal cards each into two different hands.

1.Create a new deck of cards which will be a list a 52 strings where the strings are similar to "Ace of Clubs"
2.When deck is complete list of cards should be shuffled with Fisher Yates
3.Then show top two cards

Example
Ace of spades Ace of Diamonds Ace of Clubs Ace of Hearts
2 -->
3 -->
4 -->
5 -->
6 -->
7 -->
8 -->
9 -->
10 -->
j -->
q -->
k -->

Data (data Structure)
String, list, looping, index
There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".

Algorithm
A

- Make a new list of strings named deck
- Initialize the list of strings with 52 explicitly stated cards from example sections
- Shuffle the cards with Fisher Yates (paste algo here )

  numberOfCards = length of our deck

  for rightIndex from numberOfCards - 1 down to 1 do:
  leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")

  Now swap the values at rightIndex and leftIndex by doing this:
  leftCard = the value from deck[leftIndex]
  rightCard = the value from deck[rightIndex]
  deck[rightIndex] = leftCard
  deck[leftIndex] = rightCard

- first card = deck[0]
- second card = deck[1]
- print first and second card

B Using tools NESTED LOOPING

- Make a new list of the fours suits
- Make of a list of 13 ranks and call this list ranks
- Make a new list of strings namer 'deck'
- Make a loop that foes through the list
  Make a loop that goes through all the 'ranks'
  for each rank, make a new string of the form $"{rank} "of" ${clubs}"
  add newly formed string to the end of the deck list - For Suit = Clubs
  Make a loop that goes through all the ranks
  for each rank, make a new string of the form $"{rank} of clubs"
  add newly formed string to the end of the deck list - For Suit = Diamonds
  Make a loop that goes through all the ranks
  for each rank, make a new string of the form $"{rank} of diamonds "
  add newly formed string to the end of the deck list

        - For Suit = Spades
            Make a loop that goes through all the ranks
              for each rank, make a new string of the form $"{rank} of spades"
              add newly formed string to the end of the deck list

        - For Suit = Hearts
            Make a loop that goes through all the ranks
              for each rank, make a new string of the form $"{rank} of hearts"
              add newly formed string to the end of the deck list

  -Same as Algo A
