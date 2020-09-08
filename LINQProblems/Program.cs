using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth",/* “mathematics” */};
            var thWords = words.Where(w => w.Contains("th"));
            foreach (var word in thWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var noDuplicateNames = names.Distinct();
            foreach (var name in noDuplicateNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            //4.Write a function that takes in a string of letters(i.e. “Terrill”) and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        }
    }
}
