using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList Abstract class
 * Version: 0.1 - Created the Hand class
 */

namespace COMP123_S2017_FinalExam_300926213
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        int _highestCardIndex;

        // PUBLIC PROPERTIES
        public int HighestCardIndex
        {
            get
            {
                return this._highestCardIndex;
            }

            set
            {
                this._highestCardIndex = value;
            }
        }

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            this.HighestCardIndex = -1;
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// This method returns a new List of Cards that
        /// only contains the highest cards of the hand
        /// </summary>
        /// <returns></returns>
        public List<Card> HighestCards()
        {
            var highest = (from card in this
                           orderby card.Face descending
                           select card).First();

            // For Debugging only
            //Console.WriteLine($"{highest.Face} of {highest.Suit}");

            var highestCards = (from card in this
                                where card.Face == highest.Face
                                select card).ToList();

            // set the HighestCardIndex
            this.HighestCardIndex = this.IndexOf(highest);

            return highestCards;
        }
    }
}