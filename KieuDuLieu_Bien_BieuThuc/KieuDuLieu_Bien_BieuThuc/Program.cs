using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KieuDuLieu_Bien_BieuThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            int soLuong = 0;
            double diemToan = 9.2;
            int x = 1;
            String name = "Quang";
            double d = 1 / 2;
            double d1 = (double)1 / 2;
            double d2 = 1.0 / 2;


            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Điểm toán ={0}", diemToan);  
            Console.WriteLine("Tên = {0},Điểm toán ={1}", name, diemToan);
            Console.WriteLine("d={0}/{1}= {2}", 1, 2, d);
            Console.WriteLine("d={0}/{1}= {2}", 1, 2, d1);
            Console.WriteLine("d={0}/{1}= {2}", 1, 2, d2);

            var t = 5;
            Console.WriteLine("Kiểu của t={0}", t.GetType().ToString());
            t = 10000;

            const double PI = 3.14;
            Console.ReadLine();


        }
    }
}
