using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual  void ShowInfo() 
        {
            Console.WriteLine("Человек\nИмя: " + Name + "\n" + "Возраст: " + Age + "\n");
        }
    }
    class Student : Person
    {
        public string HighSchoolName { get; set; }

        public Student(string name, int age, string hsName)
            : base(name, age)
        {
            HighSchoolName = hsName;
        }
        public override void  ShowInfo() 
        {
            Console.WriteLine("Студент\nИмя: " + Name + "\n" + "Возраст: " + Age + "\n" + "Название ВУЗа: " + HighSchoolName + "\n");
        }
    }
    class Pupil : Person
    {
        public string Form { get; set; }

        public Pupil(string name, int age, string form)
            : base(name, age)
        {
            Form = form;
        }
        public override void ShowInfo() 
        {
            Console.WriteLine("Ученик(ца)\nИмя: " + Name + "\n" + "Возраст: " + Age + "\n" + "Класс: " + Form + "\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();
            persons.Add(new Person("A", 32));
            persons.Add(new Student("B", 21, "МГУ"));
            persons.Add(new Pupil("C", 12, "7 класс"));

            foreach (Person p in persons)
                p.ShowInfo();

            Console.ReadKey();
        }
    }
}
