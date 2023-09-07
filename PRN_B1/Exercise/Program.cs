using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseList list = new CourseList();
            list.ReadListOfCoursesFromFile(@"TextFile.txt"); //@ nghĩa là đánh dấu: không có gì đặc biệt
            //list.InputListOfCourse();
            list.DisplayListOfCourse();
            list.SortByID();
            list.DisplayListOfCourse();
        }
    }
}
