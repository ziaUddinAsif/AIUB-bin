using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        private string name;
        private int age;
        private int nid;
        protected string gender;

        public Person()        
        {
            Console.WriteLine("Default cons of person");
        }
        public Person(string name,int age,int nid ,string gender)
        {
            
            this.name = name;
            this.age = age;
            this.nid = nid;
            this.gender = gender;
            Console.WriteLine("Para cons of person");
        }
        public void showInfoPerson()
        {
            Console.WriteLine("-_-Show Details_--_");
            Console.WriteLine($"Name:{name}\nAge:{age}\nNationID:{nid}\nGender:{gender}");
           
        }
       
    }
    class Student:Person
    {
        private double cgpa;
        private int sid;

        public Student()
        {
            Console.WriteLine("Default cons of student");
        }
        public Student(string name, int age, int nid, string gender, double cgpa, int sid):base(name,age,nid,gender)
        {
            
            this.cgpa = cgpa;
            this.sid = sid;
            Console.WriteLine("Para cons of student");
        }
        public void showStudentInfo()
        {
            base.showInfoPerson();
            Console.WriteLine($"Cgpa:{cgpa}\nStudentID:{sid}");
        }
    }
    class ClubStudent:Student
    {
        private string clubname;
        private string position;
        public ClubStudent()
        {
            Console.WriteLine("Default cons of club stundet");
        }
        public ClubStudent(string name, int age, int nid, string gender, double cgpa, int sid,string clubname,string position):base(name, age, nid, gender,cgpa,sid)
        {
            this.clubname = clubname;
            this.position = position;
            Console.WriteLine("Para cons of club student");
        }
        public void showClubStudentInfo()
        {
            base.showStudentInfo();
            Console.WriteLine($"Club Name:{clubname}\nPosition:{position}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Asif", 22, 4345665, "Male");
            p1.showInfoPerson();
            Console.WriteLine();
            Student s1 = new Student("Mattra", 21, 6543243, "Male",3.5,68);
            s1.showStudentInfo();
            Console.WriteLine();
            ClubStudent cs1 = new ClubStudent("Mahidul",24,34567777,"Male",3.3,12,"Shomoy","General Member");
            cs1.showClubStudentInfo();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
