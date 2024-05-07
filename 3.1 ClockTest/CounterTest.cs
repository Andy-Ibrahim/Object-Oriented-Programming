using NUnit.Framework;
using clock;

namespace CounterTest
{
    public class Tests
    {

        public Counter _testCounter;

        [SetUp]
        public void Setup()
        {
            _testCounter = new Counter("TestCounter");

        }


        [Test]
        public void InitialCountValue()
        {
            Assert.That(_testCounter.Ticks, Is.EqualTo(0));
          
        }

        [Test]
        public void CounterIncrement()
        {

            for (int i = 0; i < 5; i ++)
            {
                _testCounter.Increment();
            }

            Assert.That(_testCounter.Ticks, Is.EqualTo(5));

        }


        [Test]
        public void ResetCounter()
        {
            for (int i = 0; i < 5; i ++)
            {
                _testCounter.Increment();
            }

            _testCounter.Reset();

            Assert.That(_testCounter.Ticks, Is.EqualTo(0));

        }

        
    }

}

