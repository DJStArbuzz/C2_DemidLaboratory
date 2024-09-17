using System;
using System.Linq;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime;

namespace InterfaceExample
{
    class Student
    {
        private int year;

        public int GetYear()
        {
            return year;
        }
        public void SetYear(int value)
        {
            if (value < 1)
                year = 1;
            else if (value > 5)
                year = 5;
            else year = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.SetYear(6);
            Console.WriteLine(st1.GetYear());
            Console.ReadKey();
        }
    }
}
