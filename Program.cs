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
            Console.WriteLine("");

            int weapon = 0;

            //Console.WriteLine("BEFORE Arrays: ");
            //Console.WriteLine("");
            int pistolAmmo = 6;
            int shotGunAmmo = 2;
            int bfgAmmo = 20;

            //if (weapon == 0)
            //{
            //    Console.WriteLine("Pistol Ammo: " + pistolAmmo);
            //    Console.WriteLine("");
            //}
            //else if (weapon == 1)
            //{
            //    Console.WriteLine("Shot Gun Ammo: " + shotGunAmmo);
            //    Console.WriteLine("");
            //}
            //else if (weapon == 2)
            //{
            //    Console.WriteLine("Bfg Ammo" + bfgAmmo);
            //    Console.WriteLine("");
            //}


            Console.WriteLine("Arrays: ");
            Console.WriteLine("");

            int[] ammo; // "type[]" declaring an array, "int[]" declares an array of integers.
            ammo = new int[3];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 20;

            string[] weaponName = new string[3];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shot Gun";
            weaponName[2] = "BFG";


            Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);












            Console.ReadKey(true);
        }
    }
}
