using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            //1.Khai báo mảng 
            int[] stt;
            char[] ch;
            string[] ten;

            //2.Khai báo mảng
            //tenMang = new KieuDL[so phan tu]
            stt = new int[5];//Mặc định các số phần tử là 0
            foreach (int i in stt)
            {
                Console.WriteLine("" + i);
            }
            Console.WriteLine("Mảng stt2 là: ");
            int[] stt2 = new int[7];
            foreach (int i in stt2)
            {
                Console.Write(" " + i);
            }

            //3.Khởi tạo và gán giá trị cho mảng
            //Kieu du lieu [] ten_mang = new Kieudulieu[So_phan_tu]{pt1,pt2,pt3,....};
            int[] mang2 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine();
            Console.WriteLine("mảng 2 là");
            foreach (int i in mang2)
            {
                Console.Write(" " + i);
            }

            //4.Khởi tạo 1 mảng ngẫu nhiên
            Random r = new Random();
            int[] mang3 = new int[3] { r.Next(11), r.Next(12), r.Next(41) };
            Console.WriteLine();
            Console.WriteLine("mảng 3 là");
            foreach (int i in mang3)
            {
                Console.Write(" " + i);
            }

            //5.Kiểm tra độ dài Length
            int doDai = mang2.Length;
            Console.WriteLine();
            Console.WriteLine("Số phần tử của mảng 2:" + doDai);

            //6.Truy xuất phần tử qua index
            int[] mang4 = { 1, 3, 5 };
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[1]);
            Console.WriteLine(mang4[mang4.Length - 1]);

            //7.Thay đổi giá trị phần tử của mảng bằng cách gọi index
            int[] mang5 = { 1, 3, 5 };
            mang5[1] = 100;
            Console.WriteLine("mảng 5 sau khi thay đổi giá trị là");
            foreach (int i in mang5)
            {
                Console.Write(" " + i);
            }
                Console.WriteLine();
            //8.Duyệt mảng for(duyệt theo index)
            int[] mang6 = { 1, 3, 5, 7, 9 };
            for(int i = 0;i < mang6.Length; i++)
            {
               Console.Write(mang6[i]+" ");
            }
               Console.WriteLine();
           
            //9.Phép gán mảng: gán mảng mới = mảng đã tồn tại (tham chiếu cùng vùng nhớ)
            int[] mang8 = { 1, 3, 5, 7, 9 };
            int[] mang9 = mang8;
            mang8[0] = 100;
            Console.WriteLine("mảng 8 sau khi đổi vị trí tại index = 0:" + mang8[0]);           
            Console.WriteLine("mảng 9 sau khi đổi vị trí tại index = 0:" + mang9[0]);
            Console.WriteLine();

            //10.CopyTo(copy đè giá trị vào mảng đã có)
            int[] mang10 = { 100, 200, 300, 400, 500 };
            int[] mang11 = { 1, 2, 3, 4, 5, 6, 7};
            mang10.CopyTo(mang11, 2);
            Console.WriteLine("mảng 11 sau khi thay đổi giá trị là");
            foreach (int i in mang11)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            //11.Copy 
            int[] mang12 = { 100, 200, 300, 400 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 3);
            Console.WriteLine("mảng 13:");
            foreach (int i in mang13)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            //12.Clone tạo ra mảng mới trên vùng nhớ mới COPY ALL CÁC PHẦN TỬ CỦA MẢNG CŨ SANG MẢNG MỚI 
            int[] mang14 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine("Mảng 15 là:");
            foreach (int i in mang15)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            //16 Reverse:  Đảo ngược mảng   
            int[] mang16 = { 1, 2, 3, 4, 5, 6, 7 };
            Array.Reverse(mang16);
            Console.WriteLine("Mảng 16 là:");
            foreach (int i in mang16)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            //17 Array.Sort() Sắp xếp mảng tăng dần
            int[] mang17 = { 1, 32, 21, 75, 54, 24, 9 };
            Array.Sort(mang17);
            Console.WriteLine("Mảng 17 là:");
            foreach (int i in mang17)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
