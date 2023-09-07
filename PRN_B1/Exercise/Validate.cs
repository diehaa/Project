using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Validate
    {
        public static int getInteger(int min, int max, string mess) 
        {
            int value;
            while (true)
            {
                try
                {
                    Console.WriteLine(mess);
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < min || value > max)
                    {
                        throw new OverflowException("Nam ngoai pham vi hop le!");
                    }
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format error! Please input again");
                }
                catch (OverflowException) //phạm vị int32
                {
                    Console.WriteLine("Vuot qua pham vi cho phep, vui long nhap lai!");
                }
            }
        }

        public static string getString(int minLength, int maxLength, string mess)
        {
            string value;
            while (true)
            {
                Console.WriteLine(mess);
                value = Console.ReadLine().Trim();
                if(value.Length >= minLength || value.Length <= maxLength)
                {
                    return value;
                }
                Console.WriteLine("Do dai xau chua phu hop, vui long nhap lai!");
            }
        }

        public static DateTime getDateTime(DateTime minDate, DateTime maxDate, string pattern, string mess) 
        {
            DateTime value;
            while (true)
            {
                try
                {
                    Console.WriteLine(mess);
                    value = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                    if (value < minDate || value > maxDate)
                    {
                        throw new OverflowException("Nam ngoai pham vi hop le!");
                    }
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format error! Please input again");
                }
                catch (OverflowException) //phạm vị int32
                {
                    Console.WriteLine("Vuot qua pham vi cho phep, vui long nhap lai!");
                }
            }
        }
    }
}
