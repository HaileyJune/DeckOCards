using System;
using System.Collections.Generic;

namespace DeckOCards
{
    class Card
    {
        string stringVal;
        string suit;
        int val;
    
        public Card(string face, string shape, int num)
        {
            stringVal = face;
            suit = shape;
            val = num;
        }
    }

    class Deck
    {
        List<Card> cards;
        

        public Deck()
        {

            cards = new List<Card>();
            string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
            // Aces
            foreach (string suit in suits)
            {
                Card newCard = new Card("Ace", suit, 1);
            }
            // 2-10
            for (int i = 2; i <= 10; i ++){
                string face = i.ToString();
                foreach (string suit in suits)
                {
                    Card newCard = new Card(face, suit, i);
                }            
            }
            // Jacks
            foreach (string suit in suits)
            {
                Card newCard = new Card("Jack", suit, 11);
            }
            // Queens
            foreach (string suit in suits)
            {
                Card newCard = new Card("Queen", suit, 12);
            }
            // Kings
            foreach (string suit in suits)
            {
                Card newCard = new Card("King", suit, 13);
            }
        }

        public Card Deal()
        {
            Card cardPulled = cards[0];
            cards.RemoveAt(0);
            return cardPulled;
        }

        public void Reset()
        {
            // How to reset without copypasta
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int shuffle = rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[shuffle];
                cards[shuffle] = temp;
            }
        }
    }

    class Player
    {
        string name;
        List<Card> hand;
        //  = new List<Card>();

        public Player(string myName)
        {
            name = myName;
            hand = new List<Card>();
        }

        public Card Draw(Deck thisDeck)
        {
            Card myCard = thisDeck.Deal();
            hand.Add(myCard);
            return myCard;
        }

        public Card Discard(int index){
            Card myCard = hand[index];
            hand.RemoveAt(index);
            return myCard;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
