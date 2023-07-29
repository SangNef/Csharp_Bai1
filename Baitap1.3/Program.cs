using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương thứ nhất: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số nguyên dương thứ hai: ");
            int b = int.Parse(Console.ReadLine());

            int gcd = TimUocSoChungLonNhat(a, b);

            Console.WriteLine("Ước số chung lớn nhất của {0} và {1} là: {2}", a, b, gcd);
            Console.ReadKey();
        }

        // Phương thức tìm ước số chung lớn nhất của hai số nguyên dương
        static int TimUocSoChungLonNhat(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
