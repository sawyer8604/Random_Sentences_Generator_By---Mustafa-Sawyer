using System;
using System.Linq.Expressions;

namespace RandomSentencesGenerator
{
    internal class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Jason", "Steve", "Sezgo" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "Kardzhali" };
            string[] verbs = { "eats", "hold", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverb = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };


            
            string input;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello, this is your first random - generadet sentence: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Click [Enter] to generate a sentence");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Write [end] to stop the program!");

            while ((input = Console.ReadLine()) != "end")
            {
                string randomName = GetRandomWords(names);
                string randomPlace = GetRandomWords(places);
                string randomVerb = GetRandomWords(verbs);
                string randomNoun = GetRandomWords(nouns);
                string randomAdverb = GetRandomWords(adverb);
                string randomDetail = GetRandomWords(details);
                string who = $"{randomName} from {randomPlace}";

                string action = $"{randomAdverb} {randomVerb} {randomNoun}";

                string sentence = $"{who} {action} {randomDetail}";

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{sentence}.");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Click [Enter] to generate a new one.");
                Console.WriteLine();
            }            

            
           
        }

        static string GetRandomWords(string[] words)
        {
            Random random = new Random();

            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;


        }
    }
}

