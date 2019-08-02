using System;
using System.Threading;

namespace ConsoleApplication6
{
    public class Explore
    {
        public static void Main(string[] arg)
        {
            Thread t1 = new Thread(CountDown);
            t1.Start();
        }

        public static void CountDown()
        {
            for (int i = 9; i >0 ; i--)
            {
                for (int j = 59; j >0; j--)
                {
                    Console.WriteLine(i.ToString("D2")+":"+j);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}