using Exercise;
using System;
using System.Collections.Generic;

namespace DemoExtensionMethod_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void DemoUsingListExtension()
        {
            List<Course> courses = new List<Course>
            {
                new Course(1, "PRN", new DateTime(2021, 1, 1)),
                new Course(1, "PRN", new DateTime(2021, 1, 10)),
                new Course(1, "PRN", new DateTime(2021, 7, 1)),
            };
            courses.Display();
        }
    }
}
