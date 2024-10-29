using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Positive Negetive , even positive or negetive, odd positive or negetive
 * 
 */
namespace ConsoleApp1
{
    internal class task5
    {
        public void CheckEO()
        {
            int num;
            Console.WriteLine("Input your number");
            num = Convert.ToInt32(Console.ReadLine());
            string result = num > 0 ? num % 2 == 0 ? Console.Write("Even positive") : Console.Write("Odd positive") : num < 0 ? num % 2 == 0 ? Console.Write("Even Negetive") : Console.Write("Odd negetive") :
    }
    }
}
