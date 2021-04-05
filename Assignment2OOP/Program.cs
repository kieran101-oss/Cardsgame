﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call method to start the program
            Deck newDeck = new Deck();
            DrawCards(newDeck);

            Console.ReadKey();
        }

        // Short program which deals one card from deck at a time and also shuffles the deck
        private static void DrawCards(Deck Deck)
        {
            Console.WriteLine("Would you like to shuffle your deck of cards? (type yes)");
            string option = Console.ReadLine();
            if (option.ToLower() == "yes")
            {
                Deck.Shuffle();
                Console.Clear();
            }

            while (true)
            {
                Console.WriteLine("Would you like to draw a card?" +
                                  "\n> Type 'yes' for yes\n> Type 'anything else' for no");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    Console.Clear();
                    Console.WriteLine($"> {Deck.Deal()}\n");
                }
                else
                {
                    Console.WriteLine("No more cards will be drawn..");
                    break;
                }
            }
        }
    }
}