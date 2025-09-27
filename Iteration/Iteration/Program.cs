using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int[] testScores = { 98, 99, 85, 82, 34, 91, 90, 94, 70, 68, 91 };
            //    List<int> passingScores = new List<int>();
            //    for (int i = 0; i < testScores.Length; i++)
            //    {
            //        if (testScores[i] > 85)
            //        {
            //            Console.WriteLine("Passing test score: " + testScores[i]);
            //        }
            //    }
            //    Console.ReadLine();

            //string[] names = { "Alicia", "Lola", "Lucy", "Joshua" };
            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Alicia")
            //    {
            //        Console.WriteLine(names[j]);
            //    }

            List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(97);
            testScores.Add(72);
            testScores.Add(32);
            testScores.Add(79);

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
                
            }
            Console.ReadLine();


        }
    }
}
