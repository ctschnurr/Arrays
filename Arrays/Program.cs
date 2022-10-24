using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static int[] ammunition = { 5, 5, 5 };
        static string[] guns = { "Handgun", "Shotgun", "Sniper Rifle" };
        static int currentWeapon = 0;
        static bool keepGoing = true;

        static void Main(string[] args)
        {
            while (keepGoing == true)
                {
                    Menu();
                }
        }

        static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("Current Weapon: " + guns[currentWeapon]);
            Console.WriteLine("");
            Console.WriteLine("Current Ammo: ");
            Console.WriteLine("");
            Console.WriteLine(guns[0] + ": " + ammunition[0]);
            Console.WriteLine(guns[1] + ": " + ammunition[1]);
            Console.WriteLine(guns[2] + ": " + ammunition[2]);
            Console.WriteLine("");
            Console.WriteLine("(F)ire Weapon");
            Console.WriteLine("(C)hange Weapon");
            Console.WriteLine("(R)estock Ammo");
            Console.WriteLine("");
            Console.WriteLine("(Q)uit");
            Console.WriteLine("");

            ConsoleKeyInfo choice;

            choice = Console.ReadKey();

            switch (choice.Key)
            {
                case ConsoleKey.F:
                    Fire();
                    break;

                case ConsoleKey.C:
                    switchWeapon();
                    break;

                case ConsoleKey.R:
                    restockAmmo();
                    break;

                case ConsoleKey.Q:
                    keepGoing = false;
                    break;
            }


        }

        static void Fire()
        {

            if (ammunition[currentWeapon] > 0)
            {
                Console.WriteLine("You fired your " + guns[currentWeapon] + "!");
                ammunition[currentWeapon] = ammunition[currentWeapon] - 1;

            }

            else
            {
                Console.WriteLine("You are out of ammo for your " + guns[currentWeapon]);
            }
        }

        static void switchWeapon()
        {
            Console.WriteLine("");
            Console.WriteLine("Which weapon do you choose?");
            Console.WriteLine("(1)" + guns[0]);
            Console.WriteLine("(2)" + guns[1]);
            Console.WriteLine("(3)" + guns[2]);
            Console.WriteLine("");

            ConsoleKeyInfo choice;
            choice = Console.ReadKey();

            bool valid = true;

            while (valid == true)
            {
                switch (choice.Key)
                {
                    case ConsoleKey.D1:

                    break;
                }
            }


        }
    }
}
