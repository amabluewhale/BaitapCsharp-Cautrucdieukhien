using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Baitap 1: Nhap so num tu ban phim. Kiem tra xem num co chia het cho 3 ko?
            Console.Write("Xin moi nhap so nguyen can xet chia het cho 3: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0)
            {
                Console.Write($"{number} la so chia het cho 3");
            }
            else
            {
                Console.Write($"{number} la so khong chia het cho 3");

            }
            Console.ReadLine();


            //Baitap 2: Viet chuong trinh nhap vao so nguyen duong n, hien thi bang cuu chuong tu 1 den n ra man hinh
            Console.WriteLine("\n Xin moi nhap so nguyen n de in ra bang cuu chuong :");
            int n = Convert.ToInt32(Console.ReadLine());

            // yeu cau ng dung nhap so nguyen duong trong truong hop ng dung nhap so am
            while (n < 1)
            {
                Console.WriteLine("Vui long nhap so nguyen duong n>= 1:");
               n = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nBang cuu chuong {i}:");
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }

            Console.ReadLine();


            //Baitap 3:Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình.
            Console.WriteLine("Xin moi nhap so nguyen can tinh tong giai thua x:");
            int x = Convert.ToInt32(Console.ReadLine());

            // yeu cau ng dung nhap so nguyen duong trong truong hop ng dung nhap so am
            while (x < 1)
            {
                Console.WriteLine("Vui long nhap so nguyen duong x>= 1:");
                x = Convert.ToInt32(Console.ReadLine());

            }
            int giaithua = 1;
            for (int i = 1; i <= x; i++)
            {
                giaithua *= i; //giaithua = giai thua x i
            }
            Console.WriteLine($"Tong giai thua cua {x} la: {giaithua}");
            Console.ReadLine();


            //Baitap 4:Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
            // so chinh phuong:  la so nguyen mu 2 vd: 3^2 = 9
            Console.WriteLine("Xin moi nhap so nguyen y can kiem tra chinh phuong:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine($"{y} Day khong phai la so chinh phuong");
            }
            else
            {
                int sqrt = (int)Math.Sqrt(y);
                if (sqrt * sqrt == y)
                {
                    Console.WriteLine($"{y} la so chinh phuong.");
                }
                else
                {
                    Console.WriteLine($"{y} khong phai la so chinh phuong.");
                }
            }
            Console.ReadLine();


            //Baitap 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong tháng ra màn hình
            Console.WriteLine("Xin moi nhap thang can xem ngay ( 1 - 12):");
            int thang = Convert.ToInt32(Console.ReadLine());

                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine($"Thang {thang} la thang co 31 ngay");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine($"Thang {thang} la thang co 30 ngay");
                        break;
                    case 2:
                        Console.WriteLine($"Thang {thang} la thang co 28 hoac 29 ngay");
                        break;
                    default:
                        Console.WriteLine("Du lieu khong hop le, xin moi nhap thang dung");
                    break;

                }
            Console.ReadLine();


            //Baitap 6:Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị kết quả ra màn hình
            //𝑆 = 1 + 2^2 + 3^3 + 4^4 + ⋯ + 𝑛^n

            Console.WriteLine("Xin moi nhap so nguyen s de tinh tong:");
            int s = Convert.ToInt32(Console.ReadLine());

            while (s < 1)
            {
                Console.Write("Vui long nhap so nguyen duong (s >= 1): ");
                s = Convert.ToInt32(Console.ReadLine());
            }

            double S = 0;
            for(int i = 1; i <= s; i++)
            {
                S += Math.Pow(i, i);
            }
            Console.WriteLine($"Tong S theo so nguyen {s} la: {S}");
            Console.ReadLine();


            //Baitap 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình.
            Console.WriteLine("Xin moi nhap so nguyen a:");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum;
                }
                else
                {
                    sum += i;
                }

            }
            Console.WriteLine($"Tong cac so le tu 1 den {a} la: {sum}");
            Console.ReadLine();


            //Baitap 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n.
            Console.WriteLine("Xin moi nhap so nguyen c de in ra man hinh cac so nguyen to tu 1 den c:");
            int c = Convert.ToInt32(Console.ReadLine());

            while (c < 1)
            {
                Console.Write("Vui long nhap so nguyen duong (c >= 1): ");
                c = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Cac so nguyen to tu 1 den {c} la:");

            for (int i = 1; i <= n; i++)
            {
                if (LaSoNguyenTo(i))
                {
                    Console.WriteLine(i + " ");
                }
            }

            Console.ReadLine();


            //Baitap 9: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng. Ví dụ, nhập vào 10 hàng, thì ta sẽ được 1 tam giác như hình bên dưới. Có thể thử vẽ thêm với hình tam giác đều, tam giác xoay ngược
            Console.WriteLine("Xin moi nhap so hang ban muon ve tam giac:");
            int d = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= d; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            //Baitap 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình.
            //F(0) = 0,F(1) = 1
            //F(n)=F(n−1)+F(n−2)(với n≥2)

            Console.Write("Xin moi nhap so nguyen e can hien thi day Fibonacci: ");
            int e = Convert.ToInt32(Console.ReadLine());

            while (e < 1)
                {
                 Console.Write("vui long nhap so nguyen duong (e >= 1): ");
                 e = Convert.ToInt32(Console.ReadLine());
                }

             Console.WriteLine($"Day Fibonacci {e} phan tu:");

             int f = 0, g = 1;

             for (int i = 0; i < n; i++)
                {
                 Console.Write(f + " ");
                 int temp = f + g;
                 f = g;
                 g = temp;
                }

              Console.ReadLine(); 
            }


        static bool LaSoNguyenTo(int so)
        {
            if (so < 2) return false;
            for (int i = 2; i * i <= so; i++)
            {
                if (so % i == 0)
                    return false;
            }
            return true;

        }

    }


}