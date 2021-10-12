using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ammo System:");
            int weapon = 0;

            Console.WriteLine("BEFORE Arrays: ");
            int pistolAmmo = 6;
            int shotGunAmmo = 2;
            int bfgAmmo = 20;

            if (weapon == 0)
            {
                Console.WriteLine("Pistol Ammo: " + pistolAmmo);
            }
            else if (weapon == 1)
            {
                Console.WriteLine("Shot Gun Ammo: " + shotGunAmmo);
            }
            else if (weapon == 4)
            {
                Console.WriteLine("Bfg Ammo" + bfgAmmo);
            }


            Console.WriteLine("Arrays: ");













            Console.ReadKey(true);
        }
    }
}
