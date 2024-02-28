using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhbmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tính chỉ số cân nặng của cơ thế.");
            Console.WriteLine("----------------------------");
            Console.Write("Nhập cân năng: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Nhập chiều cao: ");
            float height = float.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi,1);
            Console.WriteLine("BMI là: " +  bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight.");
            }else if (bmi >= 18.5 && bmi < 25.0)
            {
                Console.WriteLine("Normal.");
            }else if(bmi >=25.0 &&  bmi < 30.0)
            {
                Console.WriteLine("Overweight.");
            }
            else
            {
                Console.WriteLine("Obese.");
            }
            Console.ReadKey();

        }
    }
}
