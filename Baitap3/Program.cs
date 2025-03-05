using System;

class Program
{
    static void Main()
    {
        // Cau lenh hien thi len man hinh yeu cau nguoi dung nhap so nguyen
        Console.Write("Xin moi nhap so nguyen: ");
        int number = Convert.ToInt32(Console.ReadLine());
       

        if (number % 3 == 0)
        {
            Console.Write("Day la so chia het cho 3");
        }
        else
        {
            Console.Write("Day la so khong chia het cho 3");
        }
    }
}
        
