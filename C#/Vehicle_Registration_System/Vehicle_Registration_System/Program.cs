using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Vehicle
    {
        private string ownername;
        private string lincenseplatenum;
        private string enginenum;
        private double mileage;

        public Vehicle(string enginenum)
        {
            this.enginenum = enginenum;
        }
        public string OwnerName
        {
            get { return ownername; }
            set { ownername = value; }
        }
        public string LicensePlateNum
        {
            get { return lincenseplatenum; }
            set { lincenseplatenum = value; }
        }
        public double Mileage
        {
            get { return mileage; }
            set
            {
                if (value > 0)
                {
                    mileage = value;
                }
                else
                {
                    Console.WriteLine("Mileage cannot negetive");
                }
            }
        }
        public void Displayinfo(int title)
        {
            Console.WriteLine("--Vehile " + title + " Info---");
            Console.WriteLine($"Onwer:{ownername}\nLicense Plate:{lincenseplatenum}\nEngine Number:{enginenum}\nMileage:{mileage} km");
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("ENG56789");
            v1.OwnerName = "Asif";
            v1.LicensePlateNum = "DHA-1234";
            v1.Mileage = 15000;

            Vehicle v2 = new Vehicle("ENG99887");
            v2.OwnerName = "Mattra";
            v2.LicensePlateNum = "CTG-9876";
            v2.Mileage = 25000;

            v1.Displayinfo(1);
            v2.Displayinfo(2);
            Console.ReadLine();

        }
    }
}
