using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class CourseList
    {
        List<Course> courses;

        public CourseList() 
        {
            courses = new List<Course>();
        }


        public void InitData()
        {
            courses.Add(new Course(4, "PRJ", new DateTime(2022, 1, 1)));
            courses.Add(new Course(1, "CSD", new DateTime(2022, 12, 2)));
            courses.Add(new Course(3, "MAE", new DateTime(2022, 5, 17)));
            courses.Add(new Course(2, "PRO", new DateTime(2022, 8, 19)));
        }

        public void DisplayListOfCourse()
        {
            Console.WriteLine("=========== List Of Course ==========");
            foreach (Course c in courses)
            {
                Console.WriteLine(c); //tự động gọi đến hàm toString để display nên chỉ cần writeLine(c)
            }
        }

        public void SortByTitle()
        {
            //anonimous function, hàm vô danh
            courses.Sort
            (
                (x, y) => x.Title.CompareTo(y.Title) //delegate, nhận vào 2 Course
            );
        }


        public void SortByID()
        {
            courses.Sort
            (
                (x, y) => x.Id.CompareTo(y.Id) //delegate, nhận vào 2 Course 
                
            );

        }

        public void SortByStartDate()
        {
            courses.Sort
            (
                (x, y) => x.StartDate.CompareTo(y.StartDate) //delegate, nhận vào 2 Course
            );
        }
    }
}
