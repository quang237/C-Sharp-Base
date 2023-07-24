using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacPhepToan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 5;
            a = a + 1;
            Console.WriteLine("a={0}", a);
            Console.ReadLine();

            //Nhập vào 1 số hỏi chẵn hay lẻ:
            int b;
            Console.WriteLine("Mời bạn nhập b:");
            b = int.Parse(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine("Là số chẵn {0}", b);
            } else
            {
                Console.WriteLine("Là số lẻ {0}", b);
            }
            Console.ReadLine();

            //Nhập 1 điểm kiểm tra đậu hay rớt
            double diem;
            Console.WriteLine("mỜi bạn nhập điểm:");
            diem = double.Parse(Console.ReadLine());
            if (diem > 5)
            {
                Console.WriteLine("Điểm {0} = Đậu", diem);
            } else
            {
                Console.WriteLine("Điểm {0} = Rớt", diem);
            }
            Console.ReadLine();

            //Năm nhuần là năm chia hết cho 4 nhưng không chia hết cho 100 hoặc chia hết cho 400
            int year;
            Console.WriteLine("Mời bạn nhập 1 năm:");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} là năm nhuần", year);
            }
            else
            {
                Console.WriteLine("{0} không phải năm nhuần", year);
            }
            Console.ReadLine();

            //Tính giá trị của t = ++x - --y + z++ - 1 cho x =3 ,y =5, z =2
            int x = 3;
            int y = 5;
            int z = 2;
            int t = ++x - --y + z++ - 1;
            Console.WriteLine("x={0}, y={1}, z={2}, t={3}", x,y,z,t);
            Console.ReadLine();

            //Mời nhập 1 điểm kiểm tra giỏi hay không giỏi dùng toán tử 3 ngôi
            double d;
            Console.WriteLine("Mời bạn nhập vào 1 điểm:");
            d = double.Parse(Console.ReadLine());
            String ketqua = diem > 8 ? "Giỏi" : "Không giỏi";
            Console.WriteLine("Điểm{0} ==> {1}", d, ketqua);
            Console.ReadLine();

            //Cho a,b là 2 số nguyên, kt là 1 ký tự nhập từ bàn phím(+,-,*,/).Nếu nhập kt là phép toán nào thì tự động tính toán cho a,b dùng(Switch)
            int u, i;
            char kt;
            Console.WriteLine("Nhập u:");
            u = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập i:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phép toán(+,-,*,/):");
            kt = Console.ReadLine()[0];
            switch (kt)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", u, i, u + i);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", u, i, u - i);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", u, i, u * i);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", (double)u, (double)i, (double)u / (double)i);
                    break;
            }
            Console.ReadLine();   
        }

    }
}
