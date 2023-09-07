using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap
{
    internal class Function
    {
        public void exampleOne()
        {
            int maxAttempts = 5; //số lần cho phép đăng nhập tối đa
            int attempts = 0; //số lần đăng nhập

            while (attempts < maxAttempts)
            { 
                Console.WriteLine("Enter password: ");
                string pass = Console.ReadLine();
                if (pass == "1")
                {
                    Console.WriteLine("Log in successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Error password");
                    attempts++;
                }
            }
            if (attempts >= maxAttempts)
            {
                Console.WriteLine("Login failed!");
            }
        }

        public void exampleTwo()
        {
            int maxAttempts = 5; //số lần cho phép đăng nhập tối đa
            int attempts = 0; //số lần đăng nhập

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Enter password: ");
                int pass = Convert.ToInt32(Console.ReadLine());

                if (pass >= 1 && pass <= 10)
                {
                    Console.WriteLine("Log in successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Error password!");
                    attempts++;
                }
            }
            if (attempts >= maxAttempts)
            {
                Console.WriteLine("Login failed!");
            }
        }

        public string randomGenerate(int n)
        {
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string uperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digit = "0123456789";
            string specialCharacter = "~`!@#$%^&*()_-+={[}]|:;'\",./?";
            string passwordString = lowerCase + uperCase + digit + specialCharacter;

            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int o = random.Next(passwordString.Length);
                stringBuilder.Append(passwordString[o]); //nối chuỗi
            }
            return stringBuilder.ToString();
        }

        public void exampleThree()
        {
            string pass = randomGenerate(6);
            Console.WriteLine(pass);
        }
    }
}
