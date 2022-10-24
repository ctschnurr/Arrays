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
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Current Weapon: " + guns[currentWeapon]);
            Console.WriteLine("");
            Console.WriteLine("Current Ammo: ");
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

            choice = Console.ReadKey(true);

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
                Console.WriteLine("");
                Console.WriteLine("You fired your " + guns[currentWeapon] + "!");
                Pause();
                ammunition[currentWeapon] = ammunition[currentWeapon] - 1;

            }

            else
            {
                Console.WriteLine("You are out of ammo for your " + guns[currentWeapon] + "!");
                Pause();
            }
        }

        static void switchWeapon()
        {
            bool valid = false;

            while (valid == false)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Which weapon do you choose?");
                Console.WriteLine("");
                Console.WriteLine("(1)" + guns[0]);
                Console.WriteLine("(2)" + guns[1]);
                Console.WriteLine("(3)" + guns[2]);
                Console.WriteLine("");

                ConsoleKeyInfo choice;
                choice = Console.ReadKey(true);

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        currentWeapon = 0;
                        valid = true;
                        break;

                    case ConsoleKey.D2:
                        currentWeapon = 1;
                        valid = true;
                        break;

                    case ConsoleKey.D3:
                        currentWeapon = 2;
                        valid = true;
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Please make a valid choice.");
                        Pause();
                        break;
                }
            }
        }

        static void Pause()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.WriteLine("");
            Console.ReadKey(true);
        }

        static void restockAmmo()
        {
            ammunition[0] = 5;
            ammunition[1] = 5;
            ammunition[2] = 5;

            Console.WriteLine("");
            Console.WriteLine("Your ammo has been restocked.");
            Pause();
        }
    }
}
