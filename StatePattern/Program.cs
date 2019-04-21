using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero hero = new Hero();
            hero.HP = 100;
            for (int i=100; i>0; i-=5)
            {
                hero.HP = i;
                Console.WriteLine("HP: " + hero.HP 
                    + "\t" + "Speed: " + hero.Speed().ToString() 
                    + "\t" + "Accuracy: " + hero.AccuracyRate().ToString() 
                    + "\t" + "Critical: " + hero.CriticalRate().ToString());
            }
        }
    }
}
