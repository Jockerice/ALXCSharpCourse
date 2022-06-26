using ALXCSharpCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{

    public class ArraysAndListsDemo

    {
                       public static void Run()
        {
            int x = 4;
            int[] array1 = new int[7];


            array1[0] = 4;
            array1[1] = 2;
            array1[2] = 1;
            array1[3] = 0;
            array1[4] = 3;
            array1[5] = 4;
            array1[6] = 1;


            //typ[] nazwa = {elements }
            int[] array2 = { 4, 2, 1, 0, 3, 4, 1 };


            //foreach (typ element name in arrayName)
            Console.WriteLine("Array 1");
            foreach (int number in array1)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine("Array 2");

            foreach (int number in array2)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            Dog[] dogArray = new Dog[3];
            dogArray[0] = new Dog("Mickey", "Golden Retriever");
            dogArray[1] = new Dog("Azor", "Doberman");
            dogArray[2] = new Dog("Boorek", "Jack Russel Terrier");

            Dog westieDog = new Dog("Skiper", "WHWT");
            Dog dobermanDog = new Dog("Misio", "Doberman");
            Dog[] dogArray2 = { westieDog, dobermanDog, new Dog("Jack", "Huskey") };

            int[,] twoDAwrray = new int[2,7];
            int[,,] thereDArray = new int[2, 8, 9];

         
            Console.WriteLine("Dog Array");
            foreach (Dog dog in dogArray)
            {
                dog.Present();
                dog.Bark();
            }
            Console.WriteLine("Dog Array 2");
            foreach (Dog dog in dogArray2)
            {
                dog.Present();
                dog.Bark();
            }

        }
                public static void RunLists()
        {
            //var can be either any time, it is used in methods (not usable for declaring class properties)
            Dog dog1 = new Dog("Mickey", "Golden Retriever");
            Dog dog2 = new Dog("Azor", "Doberman");
            Dog dog3 = new Dog("Boorek", "Jack Russel Terrier");
            var dog4 = new Dog("Jack", "Huskey");

            //List<ListElemetClass> listName = new List<ListElementClass>()
            //List<Dog> dogs = new List<Dog>();
            var dogs = new List<Dog>();

            Console.WriteLine($"Lists Size: {dogs.Count}");
            dogs.Add(dog2);
            Console.WriteLine($"Lists Size: {dogs.Count}");
            dogs.Add(dog3);
            Console.WriteLine($"Lists Size: {dogs.Count}");
            dogs.Add(dog1);
            Console.WriteLine($"Lists Size: {dogs.Count}");
            dogs.Add(dog4);
            Console.WriteLine($"Lists Size: {dogs.Count}");
            dogs.Remove(dog2);
            Console.WriteLine($"Lists Size: {dogs.Count}");

            foreach (var dog in dogs)
            {
                dog.Present();
            }

            List<int> number = new List<int>();
            number.Add(1);
            number.Add(35);
            number.Add(121);
            number.Add(1200);
            Console.WriteLine(number[1]);

        }
    }
}
