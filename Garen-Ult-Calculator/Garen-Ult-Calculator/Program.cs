using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarenUltCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxHP = 3000;
            int currentHP = 3000;
            int missingHP = 0;
            int ultLvl = 3;
            double totalDmg = 0;
            double[] missingHPDamageRatio = { 3.5, 3.0, 2.5 };
            double[] ultDmg = { 175, 350, 525 };

            while (true)
            {
                Console.Write("Max HP: ");
                maxHP = Convert.ToInt32(Console.ReadLine());

                if (maxHP == 0)
                {
                    break;
                }

                currentHP = maxHP;

                //Console.Write("Current HP: ");
                //currentHP = Convert.ToInt32(Console.ReadLine());

                Console.Write("Current Ult Level: ");
                ultLvl = Convert.ToInt32(Console.ReadLine());

                //missingHP = maxHP - currentHP;

                //totalDmg = missingHP / missingHPDamageRatio[ultLvl - 1] + ultDmg[ultLvl - 1];

                //Console.WriteLine("Total Damage: " + totalDmg + "\n");

                do
                {
                    currentHP--;

                    missingHP = maxHP - currentHP;

                    totalDmg = missingHP / missingHPDamageRatio[ultLvl - 1] + ultDmg[ultLvl - 1];
                } while (totalDmg < currentHP);

                Console.WriteLine("Kill Threshold: " + currentHP + "\n");
            }
        }
    }
}
