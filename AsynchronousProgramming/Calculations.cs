using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class Calculations
    {
        public async static void Test()
        {
            await Calculate();
        }

        public async static Task Calculate() 
        {

            await Calculate1_2();
            Calculate3();   
        }   

        public async static Task Calculate1_2()
        {
           var result1 = await Task.Run(() => {
                return Calculate1();
            });

            Calculate2(result1);
        }

        public static int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculating result1");
            return 100;   
        }

        public static int Calculate2(int result1)
        {
           // Thread.Sleep(1000);
            Console.WriteLine("Calculating result2");
            return result1*2;
        }

        public static int Calculate3()
        {
           // Thread.Sleep(1000);
            Console.WriteLine("Calculating result3");
            return 300;
        }
    }   
}
 