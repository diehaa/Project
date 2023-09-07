using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Course: IComparable<Course>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public Course()
        {
        }

        public Course(int id, string title, DateTime startDate)
        {
            Id = id;
            Title = title;
            StartDate = startDate;
        }

        public override string ToString()
        {
            return $"{Id} - {Title} - {StartDate.ToString("dd-MM-yyyy")}";
        }

        public virtual void Input() //virtual để các lớp con có thể kế thừa hàm này được
        {
            Console.WriteLine("=========== Nhap thong tin course ===========");

            Id = Validate.getInteger(0, 20000, "Nhap id: ");
            Title = Validate.getString(1, 100, "Nhap title: ");
            StartDate = Validate.getDateTime(new DateTime(2023, 1, 1), new DateTime(2023, 12, 31), 
                                             "dd-MM-yyyy", "Nhap ngay bat dau: ");
        }

        public virtual void ReadDataFromLine(string line) //line có format: C|ID|Title|StartDate
        {
            string[] items = line.Split("|"); //tách từng phần tử thành mảng qua dấu hiệu phân tách
            Id = Convert.ToInt32(items[1]);
            Title = items[2];
            StartDate = Convert.ToDateTime(items[3]);
        }

        public int CompareTo(Course other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }

    class OnlineCourse: Course 
    {
        public string Meet { get; set; }

        public OnlineCourse()
        {
        }

        public OnlineCourse(int id, string title, DateTime startDate, string meet): base(id, title, startDate) 
        {
            Meet = meet;
        }

        public override string ToString()
        {
            return base.ToString() + $" {Meet}";
        }

        public override void ReadDataFromLine(string line) //line có format: OC|ID|Title|StartDate|Meet
        {
            int lastIndex = line.LastIndexOf('|');
            base.ReadDataFromLine(line.Substring(0, lastIndex)); //tách chuỗi từ 0 đến vị trí | cuối
                                                                             //ý là base ID|Title|StartDate
            Meet = line.Substring(lastIndex + 1);
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Link Meet: ");
            Meet = Console.ReadLine();
        }
    }
}
