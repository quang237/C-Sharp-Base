using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2Chieu_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] arr = new int[2, 3];
            //2.Khởi tạo và gán
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //3.Nhập giá trị cho mảng dùng 2 vòng for
            Random r = new Random();
            int dong = 3;
            int cot = 4;
            int[,] arr3 = new int[dong, cot];
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    arr3[i, j] = r.Next(50);
                }
                Console.WriteLine();               
            }
            Console.WriteLine(arr3[0, 0]);
            Console.WriteLine(arr3[0, 1]);

            //Xuất mảng bất kì
            //GetLength(0) get dòng của mảng
            //GetLength(0) get số cột
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

