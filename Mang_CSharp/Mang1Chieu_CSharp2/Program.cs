using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1Chieu_CSharp2
{
    class Program
    {
        /* 1.Viết ct tạo 1 mảng 1 chiều gồm các phần tử là số nguyên , có n phần tử ngẫu nhiên , n do người dùng nhập vào 
           2.Xuất các giá trị trong mảng
           3.Đảo ngược mảng, và xuất mảng sau khi đảo ngược
           4.Sắp xếp mảng tăng dần
           5.Tính tổng các phần tử trong mảng
           6.Cho người dùng nhập 1 số bất kì, kiểm tra số đó có tồn tại trong mảng hay không, nếu có xuất ra vị trí index của số đó trong mảng   */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập vào số phẩn tử của mảng:");
            int n = int.Parse(Console.ReadLine());
            //Khai báo mảng
            int[] Mang = new int[n];
            //duyệt mảng
            for(int i = 0; i < n; i++)
            {
                Console.Write(Mang[i]+" ");
            }

            //1.Nhập giá trị ngẫu nhiên
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Mang[i] = r.Next(100);
            }

            //2.Xuất
            Console.WriteLine("Mảng ngẫu nhiên là:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mang[i] + " ");
            }
            Console.WriteLine();

            //3.Đảo ngược mảng
            Array.Reverse(Mang);
            Console.WriteLine("Mảng sau khi đảo là:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mang[i] + " ");
            }
            Console.WriteLine();

            //4.Sort mảng
            Array.Sort(Mang);
            Console.WriteLine("Mảng sau khi sắp xếp là:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mang[i] + " ");
            }
            Console.WriteLine();

            //5.Tính tổng các pt
            int tong = 0; 
            foreach(int i in Mang)
            {
                tong += 1;
                Console.WriteLine("Tổng các phần tử của mảng là:"+tong);
            }

            //6.Tìm kiếm mảng(tìm BinarySearch chỉ áp dụng khi mảng đã sắp xếp)
            Console.WriteLine("Mời nhập số cần tìm:");
            int so = int.Parse(Console.ReadLine());
            int kq = Array.BinarySearch(Mang, so);
            if (kq == -1)
                Console.WriteLine("Ko tìm thấy");
            else
                Console.WriteLine("Tìm thấy số {0} ở vị trí i {1}", so, kq);
            Console.ReadLine();
        }
    }
}
