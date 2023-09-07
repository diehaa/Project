using Exercise;
using System;

namespace DemoDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoBasicDelegate();
            //DemoMulticast();
            DemoUsingComparison();
        }

        public static int Add(int a, int b)
        {
            Console.WriteLine("Add function");
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            Console.WriteLine("Sub function");
            return a - b;
        }

        public static void DemoBasicDelegate()
        {
            Caculation delegateObj; //khai báo 1 biến có kiểu Caculation
            delegateObj = new Caculation(Add);
            Console.WriteLine("Output: " + delegateObj(5, 4));

            delegateObj = Sub; // new Caculation(Sub);
            Console.WriteLine("Output: " + delegateObj(5, 4));
        }

        public static void DemoMulticast()
        {
            Console.WriteLine("Demo multicast");
            Caculation delegateObj = Add;
            delegateObj += Sub; //thêm hàm Sub vào danh sách đc gọi
            delegateObj += Add;
            Console.WriteLine("Output: " + delegateObj(5, 4)); //lời gọi Add, xong đến Sub
                                                               //giá trị sau cùng sẽ là hàm gọi sau cùng
            Console.WriteLine("After remove: ");
            delegateObj -= Add; //remove hàm Add ra khỏi danh sách gọi
            Console.WriteLine("Output: " + delegateObj(5, 4));
        }

        public static void DemoUsingComparison()
        {
            CourseList courseList = new CourseList();
            courseList.InitData();
            Console.WriteLine("============ Sort by ID ==========");
            courseList.SortByID();
            courseList.DisplayListOfCourse();
            Console.WriteLine("============ Sort by Title ==========");
            courseList.SortByTitle();
            courseList.DisplayListOfCourse();
        }
    }
}
