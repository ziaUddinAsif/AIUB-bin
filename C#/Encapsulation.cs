using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPet
{
    class Pet
    {
        private string pName;
        private int pAge;
        private string pType;
        public string name
        {
            get { return pName; }
            set { pName = value; }
        }
        public Pet()

        {
            pName = "not set yet";
            pAge = default;
            pType = default;
            Console.WriteLine("Default cons");
        }
        public Pet(string pName, int pAge, string pType)
        {
            Console.WriteLine("para cons");
            this.pName = pName;
            this.pAge = pAge;
             this.pType = pType;
        }
        public void setinfo()
        {
            Console.WriteLine("Enter your pet name:");
            pName = Console.ReadLine();
            Console.WriteLine("Enter your pet age:");
             pAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your pet name:");
            pName = Console.ReadLine();
        }
        public void showinfo()
        {
            Console.WriteLine($"Pet name is:{pName}\nAge:{pAge}\nType:{pType}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pet p1 = new Pet();
            p1.showinfo();

            Pet p2 = new Pet("Tommy", 32, "cat");
            p2.showinfo();

            Pet p3 = new Pet();
            p3.setinfo();
            p3.showinfo();

            p2.name = "Tom";
            p2.showinfo();
            
            Console.ReadLine();
        }
    }
}