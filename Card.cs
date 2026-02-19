using System.Runtime.InteropServices.Swift;

namespace GameOfWar
{
    public class Card
    {

        // Create a string property Suit with a private setter
        private string _suit;
        public string Suit
        {
            get { return _suit; }

            set { _suit = Suit; }
        }


        // Create an int property Rank with a private setter - values should range from 0 for a face value of 2 to 12 for an Ace
        private int _rank;
        public int Rank
        {

            get { return _rank; }

            set { _rank = Rank; }
        }


        // Create a public constructor that takes suit and rank as arguments and assigns them to Suit and Rank

        public Card(string suit, int rank)
        {
            _suit = suit;
            _rank = rank;
        }


        // Overload the > operator to compare two cards by rank
        public static void operator >(Card1, Card2) {
            
        }




        // Overload the < operator to compare two cards by rank
        public static void operator <(Card1, Card2) {
            
        }


        // Create a public string method RankString that returns a string representation of this card's rank, 2-10 and Jack, Queen, King, Ace
        public string RankString()
        {
            return $"{_rank} {_suit}";
        }
        
        
    }
}