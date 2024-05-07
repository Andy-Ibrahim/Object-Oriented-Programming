using System;

namespace clock
{
	public class Clock
	{
		// each field is a counter object of type Counter  
		private Counter _seconds;
		private Counter _minutes;
		private Counter _hours;

		//creates and initializes the Counter objects  to 0 and setting the name for the counter. 
		public Clock()
		{
			_seconds = new Counter("seconds");
			_minutes = new Counter("minutes");
			_hours = new Counter("hours");
		}


		//Will incremenet each counter by 1 and reset once > 59 for minutes and seconds and > 23 for hours.
		public void Tick()
		{
			_seconds.Increment();
			if (_seconds.Ticks > 59)
			{
				_minutes.Increment();
				_seconds.Reset();

				if (_minutes.Ticks > 59)
				{
					_hours.Increment();
					_minutes.Reset();

					if (_hours.Ticks > 23)
					{
						Reset();
					}
				}
			}					
		}

		//will Reset the Clock to "00:00:00"
		public void Reset()
		{
			_seconds.Reset();
			_minutes.Reset();
			_hours.Reset();
		}

		/// get propery to be read the time in "hh:mm:ss" in string format 
		public string Time
		{
			get { return $"{_hours.Ticks:D2}:{_minutes.Ticks:D2}:{_seconds.Ticks:D2}"; }

		}
	}
}

