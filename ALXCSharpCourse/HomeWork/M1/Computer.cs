using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.HomeWork.M1
{
    public class Computer

    {
     

        public string ComputerModel { get; set; }
        public string ComputerBrand { get; set; }
        public double ComputerPrice { get; set; }


        public Computer(string computerModel, string computerBrand, double computerPrice)
        {
            ComputerModel = computerModel;
            ComputerBrand = computerBrand;
            ComputerPrice = computerPrice;
            Console.WriteLine($" You own a {ComputerModel}  brand {computerBrand} and price");

        }

    }
    }

