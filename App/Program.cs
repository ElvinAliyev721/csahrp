using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family("Smiths", 7);
            family.Print();
            Person person = new Person("Cavid", 19);
            person.Print();
            Ferd ferd = new Ferd("filankes", 10);
            ferd.Print();
        }
        static void PlusMethod(int x, int y)
        {
            Console.WriteLine($"{x+y}");
        }

        static void PlusMethod(double x, double y)
        {
            Console.WriteLine($"{x+y}");
        }
        static void PlusMethod(double x, double y,double z)
        {
            Console.WriteLine($"{x + y+z}");
        }


    }
    class Family
    {
        public string name;
        public int number;
        public Family()
        {

        }
        public Family(string name,int number)
        {
            this.name = name;
            this.number = number;
        }
        public virtual void Print()
        {
            Console.WriteLine($"{name} family has {number} person");
        }
    }
    class Person:Family
    {
        public string pname;
        public int pnum;
        public Person(string name,int number):base(name,number)
        {
            pname = name;
            pnum = number;
        }
        public override void Print()
        {
            base.Print();
        }

    }
    class Ferd:Family
    {
        public string fname;
        public int fnum;
        public Ferd(string name,int number)
        {
            fname = name;
            fnum = number;
        }
        public override void Print()
        {
            Console.WriteLine($"{fnum} sayda {fname} adli adam var");
        }
    }
    abstract class Second
    {
        public abstract void Method();
    }
}
