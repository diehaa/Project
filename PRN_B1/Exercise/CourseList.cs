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

        public void InputListOfCourse() //hàm nhập vào danh sách Course/OnlCourse
        {
            while (true)
            {
                Console.WriteLine("Course(C) / OnlineCourse(O) / Stop(S): ");
                string type = Console.ReadLine();

                if (type.ToUpper().Equals("S")) 
                    break; //ToUpper cho phép nhập cả kí tự thường vs hoa

                else if (type.ToUpper().Equals("C"))
                {
                    Course c = new Course();
                    c.Input();
                    courses.Add(c);
                } 
                else if (type.ToUpper().Equals("O"))
                {
                    OnlineCourse oc = new OnlineCourse();
                    oc.Input();
                    courses.Add(oc);
                }
                else
                {
                    Console.WriteLine("Error, please input again!");
                }

            }
        }

        public void ReadListOfCoursesFromFile(string filename) //hàm đọc dữ liệu từ file
        {
            courses.Clear();
            using (StreamReader reader = new StreamReader(filename)) //sử dụng using khi 1 biến nào đó làm tiêu tốn tài nguyên, biến đó
            {                                                        //ra khỏi cặp ngoặc using sẽ không còn ý nghĩa -> tiết kiệm bộ nhớ
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //1 dòng trên line
                    Course course;
                    if (line[0] == 'C')
                    {
                        course = new Course();
                    }
                    else
                    {
                        course = new OnlineCourse();
                    }
                    course.ReadDataFromLine(line);
                    courses.Add(course);
                }
            }    //không cần close khi sử dụng using
            
            //reader.Close();
        }

        public void InitData()
        {
            courses.Add(new Course(1, "PRJ", new DateTime(2022, 1, 1)));
            courses.Add(new Course(2, "CSD", new DateTime(2022, 12, 2)));
            courses.Add(new Course(3, "MAE", new DateTime(2022, 5, 17)));
            courses.Add(new Course(4, "PRO", new DateTime(2022, 8, 19)));
        }

        public void DisplayListOfCourse()
        {
            Console.WriteLine("=========== List Of Course ==========");
            foreach (Course c in courses)
            {
                Console.WriteLine(c); //tự động gọi đến hàm toString để display nên chỉ cần writeLine(c)
            }
        }

        public void Search(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine("========= List Of Courses have been finded ========");
            foreach (Course c in courses)
            {
                if(c.StartDate >= startDate && c.StartDate <= endDate)
                {
                    Console.WriteLine(c);
                } else
                {
                    Console.WriteLine("No Data!");
                }    
            }
        }

        public void SearchByStartDate()
        {
            DateTime startDate = Validate.getDateTime(new DateTime(2023, 1, 1), new DateTime(2023, 12, 31),
                                                      "dd-MM-yyyy", "Nhap ngay bat dau: ");
            
            DateTime endDate = Validate.getDateTime(new DateTime(2023, 1, 1), new DateTime(2023, 12, 31),
                                                    "dd-MM-yyyy", "Nhap ngay ket thuc: ");
            Search(startDate, endDate);
        }

        public void Sort()
        {
            courses.Sort();
        }

        public void SortByID()
        {
            courses.Sort(new IdComparer());
        }

        public void SortByStartDate()
        {
            courses.Sort(new StartDateComparer());
        }
    }
}
