using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeGetSet
    {
        public string Name;
        private int Age;
        private DateTime Createat;

        public EmployeGetSet()
        {
            this.Createat = DateTime.Now;
        }
        public void SetAge(int age)
        {
            this.Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Name:{Name}; Age:{Age};Date:{Createat}");
        }
    }

    public class Ab
    {
        protected int Amount;
        protected void salary()
        {
            Console.WriteLine("salary is:"+Amount);
        }
    }

    //public class Program:Ab
    //{
    //    public static void Main()
    //    {
    //        Ab ab = new Ab();
    //        ab.salary(10000);
            
    //    }
    //}
}
