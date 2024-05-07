using System;
namespace HurdleTask1
{
	public class DataAnalyser
	{
        private SummaryStrategy _strategy;
        private List<int> _numbers = new List<int>();

        

        public DataAnalyser() : this(new List<int>(), new AverageSummary())
        {

        }

        public DataAnalyser(List<int> numbers, SummaryStrategy strat)
        {
            _numbers = numbers;
            _strategy = strat;
        }


        public SummaryStrategy Strategy
        {
            get { return _strategy; }
            set { _strategy = value; }
        }

        public void AddNumber(int num)
        {
            _numbers.Add(num);
        }

        public void summarise()
        {
            _strategy.PrintSummary(_numbers);
        }

    }
}

