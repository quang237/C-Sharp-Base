using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamCSharp
{
    class Program
    {
        //Viết hàm tìm số MAX
        static int Max(int x, int y) {
            return Math.Max(x, y);
        }
        //Viết hàm tính giây thừa
        static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)          
                gt = gt * i;
                return gt;           
        }
        //Viết hàm giải pt bậc 1
        static string GPTB1(double a, double b)
        {
            if (a == 0 && b == 0)
                return "Vo so nghiem";
            if (a == 0 && b != 0)
                return "Vo nghiem";
            return "x=" + (-b / a);
        }
        static void Main(string[] args)
        {
            {
                int M = Max(4, 1);
                Console.WriteLine(M);

                int kq = TinhGiaiThua(5);
                Console.WriteLine("{0}!={1}", 5, kq);

                string nghiem = GPTB1(5, 5);
                Console.WriteLine(nghiem);
                Console.ReadLine();

            }
        }
     
    }
}
