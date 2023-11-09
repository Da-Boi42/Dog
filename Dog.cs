using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    class Program
    {
        class Dog
        {
        public string name;
        public int age;

        
        }
        static void Main(string[] args)
        {
        Dog bob = new Dog();
        bob.name = "Bobby";
        bob.age = 5;

        Console.WriteLine(bob.age);
        Console.WriteLine(bob.name);
        }
    }
}