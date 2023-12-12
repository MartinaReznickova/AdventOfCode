
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;
using System;

namespace AoC2023_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "data1.txt";
            int num;
            long sum = 0;
            int firstNum;
            int secondNum;
            int numParse;
            List<int> numbersFromLine = new List<int>();



            StreamReader sr = new StreamReader(filepath);

            string line = "";

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line = ReplaceAllStringDigitsInLine(line);

                foreach (char s in line)
                {
                    if (char.IsDigit(s))
                    {
                        numParse = int.Parse(s.ToString());
                        numbersFromLine.Add(numParse);
                    }
                }


                firstNum = numbersFromLine.First();
                secondNum = numbersFromLine.Last();
                string twoNumbers = string.Concat(firstNum, secondNum);

                num = int.Parse(twoNumbers);


                sum += num;
                Console.WriteLine(num);

                num = 0;
                firstNum = 0;
                secondNum = 0;
                numParse = 0;
                numbersFromLine.Clear();

            }

            Console.WriteLine(sum);
        }

        static string ReplaceAllStringDigitsInLine(string line)
        {
            string originalLine = line;
            string check = "";
            bool allDigits = true;
            string[] numbers = { "one", "1", "two", "2", "three", "3", "four", "4", "five", "5", "six", "6", "seven", "7", "eight", "8", "nine", "9" };


            for (int j = 0; j < line.Length; j++)
            {

                for (int i = j; i < line.Length; i++)
                {
                    check = check + line[i];

                    if (numbers.Contains(check) && !char.IsDigit(check[0]))
                    {
                        var regex = new Regex(check);

                        int index = Array.IndexOf(numbers, check);
                        line = regex.Replace(line, numbers[index + 1], 1);
                        check = "";
                        i = Array.IndexOf(numbers, numbers[index + 1]);


                        foreach (char c in line)
                        {
                            if (!char.IsDigit(c))
                            {
                                allDigits = false;
                            }

                        }

                        if (allDigits)
                        {
                            check = "";
                            return line;
                        }

                    }

                }

                check = "";


            }

           
            if (line == originalLine)
            {
                check = "";
                return line;
            }

            else
            {
                check = "";
                return ReplaceAllStringDigitsInLine(line);
            }

            



        }







    }
}

