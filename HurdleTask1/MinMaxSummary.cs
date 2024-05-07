using System;
namespace HurdleTask1
{
	public class MinMaxSummary : SummaryStrategy
    {
        
        private int Minimum(List<int> numbers)
        {
            int minimum = numbers[0];

            foreach (int num in numbers)
            {
                if (num < minimum)
                {
                    minimum = num;
                }
            }

            return minimum;
        }


        private int Maximum(List<int> numbers)
        {
            int maximum = numbers[0];

            foreach (int num in numbers)
            {
                if (num > maximum)
                {
                    maximum = num;
                }
            }

            return maximum;
        }


        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("Max:  " + Maximum(numbers));
            Console.WriteLine("Min:  " + Minimum(numbers));
        }

    }
}

