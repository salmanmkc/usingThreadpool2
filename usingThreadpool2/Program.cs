using System;
using System.Threading;
using System.Threading.Tasks;

namespace usingThreadpool2
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            //action means delegate call to the method with no return, func needs return
            Task t = Task.Run(action:ThreadMethod);
            t.Wait();
         //   Console.ReadLine();
        }
    }
}
