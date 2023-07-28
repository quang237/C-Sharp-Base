using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuoiBase
{
    class Program
    {
        //Nhập vào 1 chuỗi , sau đó:
        //1.Đếm xem chuỗi có bao nhiêu IN HOA, in thường, số
        //2.Đếm số khoảng trắng trong chuỗi 
        static void XuLyChuoi() {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            Console.WriteLine("Mời bạn nhập 1 chuỗi:");
            s = Console.ReadLine();
            int demInThuong = 0, demInHoa = 0, demSo = 0, demKT = 0;
            char[] arr = s.ToCharArray();
            for(int i =0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                    demInThuong++;
                if (char.IsUpper(arr[i])) 
                    demInHoa++;
                if (char.IsDigit(arr[i])) 
                    demSo++;
                if (char.IsWhiteSpace(arr[i])) 
                    demKT++;
            }
            Console.WriteLine("Có{0} kí tự thường", demInThuong);
            Console.WriteLine("Có{0} kí tự hoa", demInHoa);
            Console.WriteLine("Có{0} kí tự Số", demSo);
            Console.WriteLine("Có{0} kí tự khoảng trắng", demKT);
            Console.ReadLine();
        }
        static void XuLyChuoi2()
        {
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi:");
            string s = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập chuỗi 2:");
            string s2 = Console.ReadLine();
            int kq = s.ToLower().CompareTo(s2.ToLower());// đưa về cùng định dạng và so sánh
            if(kq == 0)
            {
                Console.WriteLine("s và s2 giống nhau");
            }else if(kq < 0){
                Console.WriteLine("s < s2");
            }
            else
            {
                Console.WriteLine("s > s2");
            }
            Console.ReadLine();
        }
        static void XuLyChuoi3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "Báo Mới là một trang web tổng hợp thông tin tiếng Việt";
            //  int vt = s.IndexOf("t");
            int vt = s.LastIndexOf("t");
            Console.WriteLine("t nằm ở vị trí thứ {0}", vt);
            Console.ReadLine();
        }
       
        static void Main(string[] args)
        {
           // XuLyChuoi();
           // XuLyChuoi2();
            XuLyChuoi3();
        }
    }
}
