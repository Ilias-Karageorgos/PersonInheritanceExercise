using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonInheritanceExercise
{
    internal class Teacher : Person
    {        
        public Teacher(int age)
        {
            this.age = age;
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }

    }
}
