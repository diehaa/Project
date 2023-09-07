using Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace PRN_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
            Employee employee = new Employee();
            Student student = new Student();
            student.Id = 12; //lời gọi setter

            Console.WriteLine("Id: " +  student.Id); //lời gọi getter

            Student s1 = new Student(1, "Hang");
            s1.Display();

            SEStudent sE = new SEStudent(2, "Buoi", "C#");
            sE.Display();

            SEStudent sE1 = new SEStudent();
            sE1.Input();
            sE1.Display(); */


            /* Student s1 = new Student(1, "hoang");
            Student s2 = new Student(1, "hoang");

            if (s1.Equals(s2))
            {
                Console.WriteLine("Bang nhau!");
            }
            else
                Console.WriteLine("Khac nhau"); */

            DemoArrayList();
        }

        public static void DemoArrayList()
        {
            ArrayList a1 = new ArrayList();
            a1.Add(2);
            a1.Add(4);
            a1.Add(7);

            int sum = (int)a1[0] + (int)a1[2]; //k thể cộng 2 object với nhau nên phải ép kiểu
            Console.WriteLine(sum);


            ArrayList a2 = new ArrayList();
            a2.Add(new Student(1, "Hang"));
            a2.Add(new Student(2, "Hang"));
            a2.Add(new Student(3, "Hang"));

            ((Student)a2[0]).Display(); //ép kiểu về Student để gọi đc các hàm bên Student
        }

        public static void DemoList()
        {
            List<int> l1 = new List<int>();
            l1.Add(12);
            l1.Add(2);

            int sum = l1[0] + l1[1]; //không cần ép kiểu vì đã khai báo từ đầu cú pháp là kiểu int

            List<Student> l2 = new List<Student>();
            l2.Add(new Student(2, "Long"));
            l2.Add(new SEStudent(3, "Liem", "C#"));
            l2[1].Display();
        }
    }
}
