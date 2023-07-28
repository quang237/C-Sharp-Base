using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTIf_Else_Switch
{
    class Program
    {
        //Viết ct nhập vào 2 số kiêm tra có bằng nhau ko?
        static int KiemTraBangNhau()
        {
            int int1, int2;
            Console.WriteLine("Mời nhập số thứ nhất:");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập số thứ 2:");
            int2 = int.Parse(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} & {1} là bằng nhau:", int1, int2);
            else
                Console.WriteLine("{0} & {1} ko bằng nhau:", int1, int2);
            return KiemTraBangNhau();
        }
        //Viết chương trình kiểm tra và phân loại chiều cao
        static float ChieuCao()
        {
            float chieucao;
            Console.WriteLine("Mời nhập chiều cao(cm):");
            chieucao = float.Parse(Console.ReadLine());

            if (chieucao < 150.0)
                Console.WriteLine("Phân loại: Người lùn");
            else if (chieucao >= 150.0 && chieucao <= 165.0)
                Console.WriteLine("Phân loại: Người tầm trung");
            else if (chieucao >= 165.0 && chieucao <= 190.0)
                Console.WriteLine("Phân loại: Người cao");
            else
                Console.WriteLine("Phân loại: Siêu cao");
            return ChieuCao();
        }
        //Viết chương trình hiển thị menu các lựa chọn để tính diện tích các hình tròn, hình chữ nhật, hình tam giác tương ứng vs dữ liệu đã nhập
        //Khai báo lua_chon,r,l,w,b,h (bk, dai, rong, canh huyen, chieucao), dt = 0;
        //Tao luachon chuyen chuoi->so
        //tao menu
        //swith(luachon)
        //case1: dt= 3.14*r*r
        //case2: dt= l*w;
        //case3: dt= 0.5*b*h
        //Xuat kq
        static int TinhdtHT_HCN_TG()
        {
            int lua_chon, r, l, w, b, h;
            double dt = 0;

            Console.WriteLine("Lựa chọn 1: Tính diện tích hình tròn");
            Console.WriteLine("Lựa chọn 2: Tính diện tích hình chữ nhật");
            Console.WriteLine("Lựa chọn 3: Tính diện tích hình tam giác");
            Console.WriteLine("Mời nhập lựa chọn :");
            lua_chon = int.Parse(Console.ReadLine());

            switch (lua_chon)
            {
                case 1:
                    Console.WriteLine("Nhập bán kính hình tròn:");
                    r = int.Parse(Console.ReadLine());
                    dt = 3.14 * r * r;
                    break;
                case 2:
                    Console.WriteLine("Nhập chiều dài HCN:");
                    l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập chiều rộng HCN:");
                    w = int.Parse(Console.ReadLine());
                    dt = l * w; ;
                    break;
                case 3:
                    Console.WriteLine("Nhập cạnh huyền của tam giác:");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập chiều cao của tam giác:");
                    h = int.Parse(Console.ReadLine());
                    dt = 0.5 * b * h;
                    break;
            }

            Console.WriteLine("Diện tích hình là:{0}", dt);
            return TinhdtHT_HCN_TG();
        }
        static void Main(string[] args)
        {
            KiemTraBangNhau();
            ChieuCao();
            TinhdtHT_HCN_TG();
        }
    }
}
