using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số nguyên dương: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine("{0} là số nguyên tố.", number);
            }
            else
            {
                Console.WriteLine("{0} không là số nguyên tố.", number);
            }
            Console.ReadKey();
        }

        // Phương thức kiểm tra số nguyên dương có phải là số nguyên tố hay không
        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
