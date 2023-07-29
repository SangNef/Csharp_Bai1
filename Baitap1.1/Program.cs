using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding  = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương N: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương N.");
            }
            else
            {
                long giaiThua = TinhGiaiThua(N);
                Console.WriteLine("Giai thừa của {0} là: {1}", N, giaiThua);
            }
            Console.ReadKey();
        }

        // Phương thức tính giai thừa của một số nguyên dương N
        static long TinhGiaiThua(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            long giaiThua = 1;
            for (int i = 2; i <= n; i++)
            {
                giaiThua *= i;
            }

            return giaiThua;
        }
    }
}
