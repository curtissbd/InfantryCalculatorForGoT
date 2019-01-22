using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfantryCaculator
{
   public class SellSword
    {
        public double GetNumber()
        {
            Console.Write($"Enter number of Sellswords in your charge:       ");
            int c = int.Parse(Console.ReadLine());
            if (c < 0)
            {
                Console.WriteLine("Invalid number please enter number of Sellswords in your charge");
                c = int.Parse(Console.ReadLine());
            }
            return c * 3.8;
        }
    }
}
