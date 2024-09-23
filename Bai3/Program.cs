//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bai3
//{
//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            bai 1
//            int a;
//            Console.Write("Nhap so nguyen: ");
//            a = Convert.ToInt32(Console.ReadLine());

//            if (a % 3 == 0)
//            {

//                Console.WriteLine("\n{0} chia het cho 3", a);
//            }
//            else
//                Console.WriteLine("{0} khong chia het cho 3", a);

//            Console.ReadKey();

//            Bai 2
//            int n;

//            Console.Write("Nhap so n: ");
//            n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 1; i <= n; i++)
//                for (int j = 1; j <= 10; j++)
//                {
//                    Console.WriteLine("{0} x {1} = {2}", i, j, j * i);
//                }
//            Console.ReadKey();

//            Bai 3
//            int n;
//            int giaithua = 1;
//            int tong = 0;
//            Console.Write("Nhap so n: ");
//            n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 1; i <= n; i++)

//            {
//                giaithua = giaithua * i;
//                tong = tong + giaithua;
//            }
//            Console.WriteLine("{0}", tong);
//            Console.ReadKey();

//            Bai 4
//            int n;

//            Console.Write("Nhap so n: ");
//            n = Convert.ToInt32(Console.ReadLine());
//            a = (int)Math.Sqrt(n);
//            if (a * a == n)
//            {
//                Console.WriteLine("{0} la so chinh phuong", n);
//            }
//            else
//                Console.WriteLine("{0} khong la so chinh phuong", n);
//            Console.ReadKey();

//            Bai 5
//            kiemtrangaythang();

//            Bai 6
//            int n;
//            int tong = 0;
//            Console.Write("Nhap n: ");
//            n = Convert.ToInt32(Console.ReadLine());

//            for (int i = 1; i <= n; i++)
//            {

//                tong = tong + (int)Math.Pow(i, i);
//            }
//            Console.WriteLine("tong S la: {0}", tong);
//            Console.ReadKey();

//            Bai 7
//            int n;
//            int tong = 0;
//            Console.Write("Nhap n: ");
//            n = Convert.ToInt32(Console.ReadLine());

//            for (int i = 1; i <= n; i++)
//            {
//                if (i % 2 != 0)
//                    tong = tong + i;


//            }
//            Console.WriteLine("tong cac so le tu 1 den {0} la {1}", n, tong);
//            Console.ReadKey();

//            Bai 8
//            int n;

//            Console.Write("Nhap n: ");
//            n = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("cac so nguyen to tu 1 den {0}", n);

//            for (int i = 1; i <= n; i++)
//            {
//                if (Kiemtrasnt(i))
//                {
//                    Console.WriteLine(i + "");
//                }
//            }
//            Console.ReadKey();

//            Bai 9
//            int n;

//            Console.Write("Nhap so hang: ");
//            n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 1; i <= n; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();

//            }
//            Console.ReadKey();
//        }
//        public static bool Kiemtrasnt(int a)
//        {
//            if (a < 2)
//                return false;
//            for (int i = 2; i <= Math.Sqrt(a); i++)
//            {
//                if (a % i == 0)
//                    return false;

//            }
//            return true;
//        }
//        public static void kiemtrangaythang()
//        {
//            int songay = 0;

//            Console.Write("Nhap nam ");
//            int nam = int.Parse(Console.ReadLine());

//            Console.Write("Nhap thang ");
//            int thang = int.Parse(Console.ReadLine());

//            switch (thang)
//            {
//                case 1:
//                case 3:
//                case 5:
//                case 7:
//                case 8:
//                case 10:
//                case 12:
//                    songay = 31;
//                    break;
//                case 4:
//                case 6:
//                case 9:
//                case 11:
//                    songay = 30;
//                    break;
//                case 2:
//                    if (DateTime.IsLeapYear(nam))
//                    {
//                        songay = 29;
//                    }
//                    else
//                        songay = 28;
//                    break;
//                default:
//                    songay = 0;
//                    break;
//            }
//            Console.WriteLine("so ngay trong thang {0} la {1}", thang, songay);
//            Console.ReadKey();
//        }




//    }
//}

