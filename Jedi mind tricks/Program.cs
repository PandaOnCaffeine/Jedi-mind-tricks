using System;
using System.Collections;

namespace Jedi_mind_tricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates Dictionary
            Dictionary<string, int> people = new Dictionary<string, int>();

            //Adds "Jens" at the age of 50
            people.Add("Jens", 50);
            //Adds "Jack" at the age of 14
            people["Jack"] = 14;

            //Writes out each keyvaluepair in Dictionary people
            foreach (KeyValuePair<string, int> k in people)
            {
                Console.WriteLine(k);
            }

            //Creates Dictionary and add "luke, Han and Chewbacca"
            Dictionary<string, bool> characthers = new Dictionary<string, bool>()
            {
                { "Luke", true},
                { "Han", false},
                {"ChewBacca", false}
            };

            //Removes "Han"
            characthers.Remove("Han");

            //Writes each KeyValuePair in Dictionary Characthers
            foreach (KeyValuePair<string,bool> k in characthers)
            {
                Console.WriteLine(k);
            }

            //So console doesn't close
            Console.ReadLine();
        }
    }
}