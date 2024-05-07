using NUnit.Framework;
using clock;

namespace ClockTest
{
    public class Tests
    {
        Clock _clock;

        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }
        
        [Test]
        public void InitialCLockTime()
        {
            Assert.That(_clock.Time, Is.EqualTo("00:00:00"));            
        }


        [Test]
        public void ResetClock()
        {
            for (int i = 0; i < 86400; i++)
            {
                _clock.Tick();
            }

            _clock.Reset();

            Assert.That(_clock.Time, Is.EqualTo("00:00:00"));

        }

        [Test]
        public void SecondIncrement()
        {
            for (int i = 0; i < 59; i++)
            {
                _clock.Tick();

            }
            Assert.That(_clock.Time, Is.EqualTo("00:00:59"));

        }

        [Test]
        public void MinuteIncrement()
        {
            for (int i = 0; i < 60; i++)
            {
                _clock.Tick();
            }

            Assert.That(_clock.Time, Is.EqualTo("00:01:00"));

        }

        [Test]
        public void HourIncrement()
        {
            for (int i = 0; i < 3600; i++)
            {
                _clock.Tick();
            }
            Assert.That(_clock.Time, Is.EqualTo("01:00:00"));

        }

    }

}
