using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritanceExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student(21);
            Teacher t1 = new Teacher(30);

            s1.ShowAge();
            s1.GoToClasses();

            Console.WriteLine("-----------------------------");

            t1.Explain();




        }
    }
}
