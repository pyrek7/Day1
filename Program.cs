using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0;i<25;i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(i)
            }
        }
    }
}
