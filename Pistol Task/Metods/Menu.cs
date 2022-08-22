using System;
using System.Collections.Generic;
using System.Text;

namespace Pistol_Task.Metods
{
    class Menu
    {
        public static void Menue()
        {
            int BulletCapacity = -1;
            int BulletCount = -1;
            float Discharge = -1;
            string ShootingMode = "";
            bool input = true;
            Console.WriteLine("Please include weapon information");
            while (input)
            {
                Console.Write("Bullet Capacity:");
                input = !int.TryParse(Console.ReadLine(), out BulletCapacity);
                if (input || BulletCapacity < 0)
                {
                    ChangeTrue(ref input);
                }
            }
            input = true;
            while (input)
            {
                Console.Write("Bullet Count(BulletCount cannot be greater than BulletCapacity):");
                input = !int.TryParse(Console.ReadLine(), out BulletCount);

                if (input || BulletCount < 0 || BulletCount > BulletCapacity)
                {
                    ChangeTrue(ref input);
                }
            }
            input = true;
            while (input)
            {
                Console.Write("Discharge time:");
                input = !float.TryParse(Console.ReadLine(), out Discharge);
                if (input || Discharge < 0)
                {
                    ChangeTrue(ref input);
                }
            }
            input = true;
            int Shootmode;
            while (input)
            {
                Console.WriteLine("Select weapon mod\n1- Avto\n2- Single");
                Console.Write("Shooting Mode:");
                input = !int.TryParse(Console.ReadLine(), out Shootmode);
                if (input || Shootmode < 1 || Shootmode > 2)
                {
                    ChangeTrue(ref input);
                }
                else
                {
                    if (Shootmode == 1)
                        ShootingMode = "Avto";
                    else
                        ShootingMode = "Single";
                }
            }
            Console.Clear();
            Weapon m4 = new Weapon(BulletCapacity, BulletCount, Discharge, ShootingMode);
            int Chouse;
            string Chouse2;
            do
            {
                Console.WriteLine(" 0 - To get information \n 1- For the Shoot method\n 2 - For the Fire method\n 3 - For the GetRemainBulletCount method\n 4 - For the Reload method\n 5 - For the ChangeFireMode method \n 6 - To quit the program\n 7-Edit");

                while (!int.TryParse(Console.ReadLine(), out Chouse))
                {
                    Console.WriteLine("Please enter correctly");
                }
                Console.Clear();
                switch (Chouse)
                {
                    case 0:
                        m4.ShowInfo();
                        break;
                    case 1:
                        m4.Shoting();
                        break;
                    case 2:
                        m4.Fire();
                        break;
                    case 3:
                        Console.WriteLine(m4.GetRemainBulletCount());
                        break;
                    case 4:
                        m4.Reload();
                        Console.WriteLine("Weapon ready");
                        break;
                    case 5:
                        m4.ChangeFireMode();
                        Console.WriteLine("Shooting mode change:"+m4.ShootingMode);
                        break;
                    case 6:
                        Console.WriteLine("Thank You");
                        break;
                    case 7:
                        char Chouse1 = 'n';
                        Console.WriteLine("T - Change capacity\nS - Number of bullets\nD - Reset second");

                        if (Chouse1 != 'T' || Chouse1 != 'S' || Chouse1 != 'D')
                        {
                            while (!char.TryParse(Console.ReadLine().ToUpper(), out Chouse1)) ;
                            Console.WriteLine("Please enter correctly");
                        }
                        Console.Clear();
                        int input1;
                        switch (Chouse1)
                        {
                            case 'T':
                                Console.Write("Those currently: ");
                                Console.WriteLine(value: m4.BulletCapacity);          //mellimden sorus      
                                Console.WriteLine("Add new edit");
                                while (!int.TryParse(Console.ReadLine(), out input1))
                                {
                                    Console.WriteLine("Please enter correctly");
                                }
                                m4.BulletCapacity = input1;
                                if (m4.BulletCount > m4.BulletCapacity)
                                {
                                    m4.BulletCount = m4.BulletCapacity;
                                }

                                Console.Write("Renewed state: ");
                                Console.WriteLine(value: m4.BulletCapacity);
                                break;
                            case 'S':
                                Console.WriteLine("Add new edit");
                                Console.Write("Those currently: ");
                                Console.WriteLine(value: m4.BulletCount);
                                while (!int.TryParse(Console.ReadLine(), out input1))
                                {
                                    Console.WriteLine("Please enter correctly");
                                }
                                m4.BulletCount = input1;
                                Console.Write("Renewed state: ");
                                Console.WriteLine(value: m4.BulletCount);
                                break;
                            case 'D':
                                Console.WriteLine("Add new edit");
                                Console.Write("Those currently: ");
                                Console.WriteLine(value: m4.Discharge);
                                float input2;
                                while (!float.TryParse(Console.ReadLine(), out input2))
                                {
                                    Console.WriteLine("Please enter correctly");
                                }
                                m4.Discharge = input2;
                                Console.Write("Renewed state: ");
                                Console.WriteLine(value: m4.Discharge);
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter the correct number.");
                        break;
                }
                Console.WriteLine("If you want to continue, type YES, if you want to quit, type NO.");
                do
                {
                    Console.WriteLine("Please input correct");
                    Chouse2 = Console.ReadLine().ToUpper();
                }
                while (Chouse2 != "YES" && Chouse2 != "NO");

                Console.Clear();
            } while (Chouse2 == "YES");
        }

        private static void ChangeTrue(ref bool input)
        {
            throw new NotImplementedException();
        }
    }
}
