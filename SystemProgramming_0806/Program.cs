using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SystemProgramming_0806
{
    class Program
    {
        static async void DoSomething()
        {
            var num = await GetSomeNumber();
            for (int i = 1000; i < 2000; i++)
            {
                Console.WriteLine($"\t\tDo Something: {i}");
            }
            Console.WriteLine(num);
        }

        static Task<int> GetSomeNumber()
        {
            #region
            //for (int i = 200; i < 300; i++)
            //{
            //    Console.WriteLine($"\t\t\t{i}");
            //}
            //int number = await new Task<int>(() => 10);
            //return number;

            //var t = new Task<int>(() => 10);
            //return await t;

            //Thread.Sleep(50);
            //return 10;
            #endregion

            var t = new Task<int>(() =>
            {
                for (int i = 0; i < 500; i++)
                {
                    Console.WriteLine("\t\t\t\tGetSomeNumber");
                }
                return 10;
            });
            t.Start();
            return t;

        }

        static void Main(string[] args)
        {
            //var str = await File.ReadAllBytesAsync("");

            DoSomething();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Main: {i}");
            }
        }
    }
}
