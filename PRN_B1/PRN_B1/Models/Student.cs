using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_B1
{
    internal class Student
    {
        //private field
        int id;
        string name;

        //property (có thể có get mà k cần set)
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if(value > 0)
                {
                    id = value;
                }
                else
                    id = 0;
            }
        }

        //property viết tắt
        public string Name
        {
            get; set;
        }

        public Student()
        {
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual void Display() //virtual dùng để cho phép lớp con override
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}");
        }

        public void Input()
        {
            Console.WriteLine("Nhap ID: ");
            Id = Convert.ToInt32(Console.ReadLine()); //đọc dữ liệu nhập vào, hàm ReadLine trả về 
                                                      //dạng string nên phải convert
            Console.WriteLine("Nhap Name: ");
            Name = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Student ID: {Id}, Name: {Name}";
        }

        public override bool Equals(object obj) //ghi đè hàm so sánh 2 object
        {
            return obj is Student student &&
                   Id == student.Id &&
                   Name == student.Name;
        }
    }

    //tạo lớp SEStudent kế thừa từ lớp Student
    class SEStudent: Student
    {
        public string Skill { get; set; }

        public SEStudent(int id, string name, string skill): base(id, name) //lời gọi hàm tạo lớp cha (Student)
        {
            Skill = skill;
        }

        public SEStudent()
        {
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Skill: {Skill}");
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Skill: ");
            Skill = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $", Skill: {Skill}";
        }
    }
}
