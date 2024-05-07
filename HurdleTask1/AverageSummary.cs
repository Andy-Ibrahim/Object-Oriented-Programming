using System;
namespace HurdleTask1
{
	public class AverageSummary: SummaryStrategy
    {
        
        private float Average(List<int> numbers)
        {
            int sum = 0;
            

            foreach (int num in numbers)
            {
                sum += num;
            }

            float average; 


            average = (float) sum / numbers.Count;

            return average;
        }

        public override void PrintSummary(List<int> numbers)
        {
            
            Console.WriteLine("Average:  " + Average(numbers));
        }

    }
}

