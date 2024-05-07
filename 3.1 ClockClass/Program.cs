using System;

namespace clock
{
    public class Program
    {
        public static void Main (string[] args)
        {
            Clock clock = new Clock();

            
            for (int i = 0; i <86401; i++)
            {
            clock.Tick();

            Console.WriteLine(clock.Time);
            }
     
            Console.ReadLine();


        }
    }
}