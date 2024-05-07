using System;
namespace HurdleTask1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 0, 0, 6, 8, 5, 9, 7, 3 };
            DataAnalyser analyser = new DataAnalyser(numbers, new MinMaxSummary());

            analyser.summarise();
            analyser.AddNumber(6);
            analyser.AddNumber(7);
            analyser.AddNumber(8);
            analyser.Strategy = new AverageSummary();
            analyser.summarise();
        }
    }
}