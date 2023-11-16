using System;
using System.Text;
using System.IO;

namespace AoC_2022_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "data.txt";
          

            List<int> reindeerFood = new List<int>();
            int sumForOneReindeer = 0;
            int maxSum = 0;
            string line = "";

            StreamReader sr = new StreamReader(filepath);

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();

                if (String.IsNullOrWhiteSpace(line) == false)
                {
                    reindeerFood.Add(int.Parse(line.Trim()));
                }

                else
                {
                    sumForOneReindeer = reindeerFood.Sum();
                    if (maxSum < sumForOneReindeer)
                    {
                        maxSum = sumForOneReindeer;
                    }

                    reindeerFood.Clear();
                    sumForOneReindeer = 0;
                }
            }

            Console.WriteLine("{0}", maxSum);
        }
    }
}
