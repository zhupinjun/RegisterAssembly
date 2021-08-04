using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class ASYNC
    {
        public static void TestMain()
        {
            Console.Out.Write("Start\n");
            GetValueAsync();
            Console.Out.Write("End\n");
            Console.ReadKey();
        }

        public static async Task GetValueAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                for (int i = 0; i < 5; ++i)
                {
                    Console.Out.WriteLine(String.Format("From task : {0}", i));
                }
            });
            Console.Out.WriteLine("Task End");
        }
    }
}
