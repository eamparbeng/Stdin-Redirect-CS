using System;
using System.Threading;

namespace console_redir_out1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            for (int i = 0; i < 10000000; i++)
            {
                int dow = rand.Next(0, 6);
                DayOfWeek dayOfWeek = (DayOfWeek)dow;
                Console.WriteLine($"{dayOfWeek.ToString()}");
                if (i % 50000 == 0)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
