namespace AoC_2022_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "data.txt";

            List<int> reindeerFoodSums = new List<int>();
            int sumForOneReindeer = 0;
            string line = "";

            StreamReader sr = new StreamReader(filepath);

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();

                if (!String.IsNullOrEmpty(line) )
                {
                    sumForOneReindeer += int.Parse(line.Trim());
                }

                else
                {
                    reindeerFoodSums.Add(sumForOneReindeer);
                    sumForOneReindeer = 0;
                }
            }

            reindeerFoodSums.Sort();
            reindeerFoodSums.Reverse();

            int totalBestThree = reindeerFoodSums.Take(3).Sum();

            Console.WriteLine(totalBestThree);
        }
    }
}
