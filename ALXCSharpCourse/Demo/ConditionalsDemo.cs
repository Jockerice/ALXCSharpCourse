using ALXCSharpCourse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class ConditionalsDemo
    {
        public static void Run()
        {
            int number = 65;

            if (number > 15)
            {
                Console.WriteLine($"The number {number} is greater than 15");
            }
            else if (number == 15)
            {
                Console.WriteLine($"The number {number} is equal to 15");
            }
            else if (number == 3)
            {
                Console.WriteLine("I am a potato!");
            }
            else
            {
                Console.WriteLine($"The number {number} is smaller than 15");
            }
        }

        public static void RunNumberApp()
        { 
            Console.WriteLine("Number app ");
            Console.Write("Enter a number ");
            int x;
            bool succeeded = Int32.TryParse(Console.ReadLine(), out x);

            //int x = Convert.ToInt32(Console.ReadLine());

            if (succeeded)
            {
                if (x%2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine($"The number {x} is odd");
                }
            }
            else
            {
                Console.WriteLine("The given input is not a number!");
            }


        }
        public static void RunSwitch()
        {
            var sex = Sex.FAMALE;
            switch (sex)
            {
                case Sex.MALE:
                    Console.WriteLine("The sex is male");
                    break;

                case Sex.FAMALE:
                    Console.WriteLine("The sex is famale");
                    break;
                case Sex.CUSTOM:
                    Console.WriteLine("The sex is custom");
                    break;

                default:
                    Console.WriteLine("default");
                    break;  
              
              }
            Console.WriteLine("Switch end...");


            var number = 5;
            switch (number)

            {
                case 0:
                    Console.WriteLine("Hello");
                    break;

                case 1:
                    Console.WriteLine("I am potato");
                    break;
                case 126:
                    Console.WriteLine("C#...  ");
                    break;

                default:
                    Console.WriteLine("default");
                    break;


            }
            Console.WriteLine("Switch end...");


        }
    }
}
