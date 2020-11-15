using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinChartPrintReflection
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return Name + Age.ToString();
        }
    }

    class Program2
    {
        static void Main()
        {   // DeepCopy
            Person p1 = new Person("홍길동", 30);
            Person p2 = p1;
            p2.Name = "김개똥";

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}
