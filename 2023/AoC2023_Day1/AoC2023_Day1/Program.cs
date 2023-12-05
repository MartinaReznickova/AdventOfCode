namespace AoC2023_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "data1.txt";
            int firstNum = 0;
            int secondNum = 0;
            int num = 0;
            long sum = 0;
            string numbers = "0123456789";



            StreamReader sr = new StreamReader(filepath);

            string line = "";

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                var indexFirstNum = line.IndexOfAny(numbers.ToCharArray());
                firstNum = int.Parse(line[indexFirstNum].ToString());
                line.Reverse();
                var indexSecondNum = line.IndexOfAny(numbers.ToCharArray());
                secondNum = int.Parse(line[indexSecondNum].ToString());

                string twoNumbers = firstNum.ToString() + secondNum.ToString();

                num = int.Parse(twoNumbers);

                sum += num;

                num = 0;
                firstNum = 0;
                secondNum = 0;




                
            }

            Console.WriteLine(sum);
        }
    }
}
