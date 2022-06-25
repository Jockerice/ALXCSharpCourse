using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class VariablesDemo
    {
        public static void Run()
        {
            Console.WriteLine("Variables demo");
            int number = 10;
            bool booleanValue = true;
            bool booleanValue1 = false;
            //string name = "Oskar";
            double number2 = 0.22;
            float number3 = (float)number2;


            Console.WriteLine(1);
            Console.WriteLine(booleanValue);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            /*
             *string name1 = Console.ReadLine();

            //last name 
            Console.WriteLine("Enter last name");

            string lastName1 = Console.ReadLine();
            //phone number
            Console.WriteLine("Enter phone number");
            string phoneNumber1 = Console.ReadLine();
            //height
            Console.WriteLine("Enter height");
            double height = Convert.ToDouble(Console.ReadLine());  
            //address
            Console.WriteLine("Enter streetName");
            string streetName1 = Console.ReadLine();
            Console.WriteLine("Enter building number ");
            string buildingNumber1 = Console.ReadLine();
            Console.WriteLine("Enter flat");
            string flatName1 = Console.ReadLine();
            Console.WriteLine("Enter postal code ");
            string postalCode1 = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city1 = Console.ReadLine();
             */



            //name
            Console.WriteLine("Personal data from \n");
            Console.Write(" Enter name:");
            string name1 = Console.ReadLine();

            //last name 
            Console.Write("Enter last name: ");

            string lastName1 = Console.ReadLine();
            //phone number
            Console.Write("Enter phone number: ");
            string phoneNumber1 = Console.ReadLine();
            //height
            Console.Write("Enter height: ");
            double height1 = Convert.ToDouble(Console.ReadLine());  
            //address
            Console.Write("Enter streetName: ");
            string streetName1 = Console.ReadLine();
            Console.Write("Enter building number: ");
            string buildingNumber1 = Console.ReadLine();
            Console.Write("Enter flat: ");
            string flatName1 = Console.ReadLine();
            Console.Write("Enter postal code: ");
            string postalCode1 = Console.ReadLine();
            Console.Write("Enter city: ");
            string city1 = Console.ReadLine();
            string address1 = $"Ulica  {streetName1}{buildingNumber1}/{flatName1} {postalCode1} {city1} ";
            Console.WriteLine();
            Console.WriteLine($" {name1} {lastName1} {phoneNumber1} {height1} {streetName1}{buildingNumber1}/{flatName1} {postalCode1} {city1}");

            

 Console.WriteLine($"Ulica {streetName1}{buildingNumber1}/{flatName1} {postalCode1} {city1}");
            
            }

        public static void RunCalculator()
        {

            Console.WriteLine("Simple Calculator");
            Console.Write("Enter x number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"{x} + {y} = {x + y} ");
            Console.WriteLine($"{x} - {y} = {x - y} ");
            Console.WriteLine($"{x} * {y} = {x * y} ");
            Console.WriteLine($"{x} / {y} = {Convert.ToDouble(x) / Convert.ToDouble(y)}");




        }


        public static void RunLogicalCalculator()
        {
            Console.WriteLine("Simple Logical Calculator");
            Console.Write("Enter x number: ");
            bool x = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter y number: ");
            bool y = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"{x} AND {y} = {x && y} ");
            Console.WriteLine($"{x} OR  {y} = {x || y} ");
            Console.WriteLine($"{x} XOR {y} = {x ^ y} ");



        }






    }
    }

