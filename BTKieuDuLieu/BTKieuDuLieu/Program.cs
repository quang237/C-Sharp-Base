using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKieuDuLieu
{
    class Program
    {
        //Viết ct nhập chữ cái và hiển thị theo chiều ngược lại
        static char ChuCai() {
            Console.OutputEncoding = Encoding.UTF8;
            char letter1, letter2, letter3;
            Console.WriteLine("Mời nhập chữ cái 1:");
            letter1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập chữ cái 2:");
            letter2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập chữ cái 3:");
            letter3 = char.Parse(Console.ReadLine());

            Console.WriteLine("Hiển thị chữ cái theo chiều xuôi:");
            Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
            Console.WriteLine("Hiển thị chữ cái theo chiều ngược lại:");
            Console.WriteLine("{0}{1}{2}", letter3, letter2, letter1);
            Console.ReadLine();
            return ChuCai();
        }

        //Viết ct tìm chu vi và diện tích hình tròn
        static double HinhTron() {
            double r, cv, dt;
            double PI = 3.14;
            Console.WriteLine("Mời bạn nhập bán kính:");
            r = double.Parse(Console.ReadLine());
            cv = 2 * PI * r;
            Console.WriteLine("Chu vi của đường tròn:{0}", cv);
            dt = PI * r * r;
            Console.WriteLine("diện tích của đường tròn:{0}", dt);
            Console.ReadLine();
            return HinhTron();
        }

        //Viết ct tính diện tích và thể tích của hình cầu
        static float HinhCau()
        {
            float r;
            float PI = 3.1415432f;          
            Console.WriteLine("Nhập bán kính hình cầu:");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình cầu:");
            Console.WriteLine(4 * PI * (r * r));
            Console.WriteLine("Thể tích hình cầu:");
            Console.WriteLine(4 / 3 * PI * (r * r * r));
            Console.ReadLine();
            return HinhCau();
        }
        static void Main(string[] args)
        {
              ChuCai();
              HinhTron();
              HinhCau();
        }
    }
}
