using Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod_LinQ
{
    static class ListExtension  
    {
        public static void Display(this List<Course> courses) //extension method
        {
            Console.WriteLine("List of courses: ");
            foreach(Course c in courses)
            {
                Console.WriteLine(c);
            }
        }
    }
}
