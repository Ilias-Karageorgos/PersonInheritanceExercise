using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritanceExercise
{
    internal class Student : Person
    {
        public Student(int age)
        {
            this.age = age;
        }

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge ()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
}
