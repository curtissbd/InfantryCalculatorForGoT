using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfantryCalculator
{
  public  class Calculator
    {
        
        Axeman axeman = new Axeman();
        Footman footman = new Footman();
        ManAtArms manAtArms = new ManAtArms();
        Militia militia = new Militia();
        SellSword sellSword = new SellSword();
        public void retrieveInfo()
        {
            double totalMilitiaPower = militia.GetNumber();
           Console.WriteLine($"Your total militia power is {totalMilitiaPower:n} ");
            double totalFootmanPower = footman.GetNumber();
            Console.WriteLine($"Your total footman power is {totalFootmanPower:n} ");
            double totalSellSwordPower = sellSword.GetNumber();
            Console.WriteLine($"Your total sell sword power is {totalSellSwordPower:n} ");
            double totalManAtArms = manAtArms.GetNumber();
            Console.WriteLine($"Your total man at arms power is {totalManAtArms:n} ");
            double totalAxemanPower = axeman.GetNumber();
            Console.WriteLine($"Your total axeman power is {totalAxemanPower:n} ");
            double totalPower = totalMilitiaPower + totalFootmanPower + totalSellSwordPower +  totalManAtArms + totalAxemanPower;
            Console.WriteLine($"Your total infantry power is {totalPower:n} ");
            Console.ReadLine();
        }
    }
}
