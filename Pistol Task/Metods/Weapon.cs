using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pistol_Task.Metods
{
    class Weapon
    {
        private int _bulletCapacity;
        private int _bulletCount;
        private float _discharge;
        private string _shootingMode;
        public int BulletCapacity
        {
            get
            {
                return _bulletCapacity;
            }
            set
            {
                if (value >= 0)
                {
                    _bulletCapacity = value;

                }
            }
        }
        public int BulletCount
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                if (value >= 0 && value <= BulletCapacity)
                {
                    _bulletCount = value;
                }
            }
        }
        public float Discharge
        {
            get
            {
                return _discharge;
            }
            set
            {
                if (value > 0)
                {
                    _discharge = value;
                }
            }
        }
        public string ShootingMode
        {
            get
            {
                return _shootingMode;
            }
            set
            {
                if (value == "Single" || value == "Avto")
                {
                    _shootingMode = value;
                }
            }
        }
        public Weapon(int BulletCapacity, int BulletCount, float Discharge, string ShootingMode)
        {
            this.BulletCapacity = BulletCapacity;
            this.BulletCount = BulletCount;
            this.Discharge = Discharge;
            this.ShootingMode = ShootingMode;
        }
        public void Shoting()
        {
            if (ShootingMode == "Single")
            {
                if (BulletCount > 1)
                {
                    BulletCount -= 1;
                    Console.WriteLine("1 shot fired");
                }
                else if (BulletCount <= 1)
                {
                    BulletCount -= 1;
                    Console.WriteLine("1 shot fired");
                    Reload();
                }

            }
            else if (ShootingMode == "Avto")
            {
                BulletCount = 0;
                Console.WriteLine("All bullet fire");
                Console.WriteLine("Please reload gun");
            }

        }
        public void Fire()
        {
            if (ShootingMode == "Avto")
            {
                if (BulletCapacity > 0)
                {
                    float time = BulletCapacity / Discharge * BulletCount;
                    Console.WriteLine("Seconds of comb discharged: " + time);
                    BulletCount = 0;
                    Console.WriteLine("Please reload gun");
                }
            }
            else
            {
                float time = (BulletCapacity / Discharge * BulletCount) + BulletCount / 2;
                Console.WriteLine("Seconds of comb discharged: " + time);
                BulletCount = 0;
                Console.WriteLine("Please reload gun");

            }
        }
        public int GetRemainBulletCount()
        {
            int caps = BulletCapacity - BulletCount;
            return caps;
        }
        public int Reload()
        {
            Console.WriteLine("Reloding...");
            Thread.Sleep(4000);
            BulletCount = BulletCapacity;
            Console.WriteLine("Loded");
            return BulletCount;
        }
        public void ChangeFireMode()
        {
            if (ShootingMode == "Single")
            {
                ShootingMode = "Avto";
            }
            else if (ShootingMode == "Avto")
            {
                ShootingMode = "Single";
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Bullet capacity of the comb         " + BulletCapacity + "\nThe number of bullets in the comb   " + BulletCount + "\nComb discharge second               " + Discharge + " sec." + "\nShooting mode                       " + ShootingMode);
        }

        public static void ChangeTrue(ref bool inpute)
        {
            Console.WriteLine("Please enter correctly");
            inpute = true;
        }       // Daxil etdiyimiz inpute deyisenine True menimsedir eger daxil edilen melumat falesdirsa
    }
}
