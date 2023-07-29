using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int maxNumber = int.MinValue;
            int number;

            do
            {
                Console.Write("Nhập một số nguyên (nhập 0 để kết thúc): ");
                number = int.Parse(Console.ReadLine());

                if (number != 0 && number > maxNumber)
                {
                    maxNumber = number;
                }
            } while (number != 0);

            if (maxNumber == int.MinValue)
            {
                Console.WriteLine("Không có số nào được nhập.");
            }
            else
            {
                Console.WriteLine("Số lớn nhất trong các số đã nhập là: " + maxNumber);
            }
            Console.ReadKey();
        }
    }
}
