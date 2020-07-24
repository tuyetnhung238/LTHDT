using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||                                       ||");
            Console.WriteLine("||                                       ||");
            Console.WriteLine("||        *       * * * * * *       **        **                              ||");
            Console.WriteLine("||       ***      * * * * * *      ****      ****              ||");
            Console.WriteLine("||      ** **         ***         **  **    **  **        ||");
            Console.WriteLine("||     *******        ***        **    **  **    **       ||");
            Console.WriteLine("||    ***   ***       ***       **       ****     **    ||");
            Console.WriteLine("||   ***     ***      ***      **        ****      **    ||");


            int NTK = 1;
            BankAccount[] Atm = new BankAccount[NTK];

            DangNhapTK(Atm);

            Run admin = new Run();
            admin.NhapTTTK(Atm);

        }
        static public void DangNhapTK(BankAccount[] Arr)
        {

            Console.WriteLine("\n\t\t*************************");
            Console.WriteLine("\n\t\t-----L-O-G-I-N-----");
            Console.WriteLine("\n\t\t*************************");
            int Dem1 = 0;
            int Dem2 = 0;
            int Dem3 = 0;
            int NVT = -1;
            //vòng lặp thực hiên công việc kiểm tra có tìm thấy tài khảon đăng nhập hay không
            do
            {

                Console.WriteLine("Nhập ID:");
                NViTriID = Console.ReadLine();
                //vòng lặp đếm số lần tìm thấy địa chỉ ID
                for (int i = 0; i < NTK; i++)
                {
                    if (Arr[i].ID.Equals(NViTriID))
                    {
                        Dem1++;
                    }
                }
                Console.WriteLine("Nhập PIN:");
                //vòng lặp đếm số lần tìm thấy mã PIN
                for (int j = 0; j < NTK; j++)
                {
                    int i = 0;
                    char a = Console.ReadKey().KeyChar;
                    //ConsoleKeyInfo get = Console.ReadKey(true);
                    //char a = get.KeyChar;
                    while ((a != '\n' && a != '\r') && a != '\t' && a != ' ' && (i < 12))
                    {
                        if ((a != '\n' && a != '\r') && a != '\t' && a != ' ' && (i < 12) && (a != 8))
                        {
                            Console.WriteLine("*");
                            NViTriPW += a;
                            i++;
                            a = Console.ReadKey().KeyChar;
                        }
                    }

                    if (Arr[j].Password.Equals(NViTriPW))
                    {
                        Dem2++;
                        _nVT = j;
                    }
                }
                if (Dem1 == 0 || Dem2 == 0)
                {
                    Console.WriteLine("\nTài khoản hoặc Mật khẩu không tìm thấy! ");
                    Dem3++;
                    if (Dem3 == 3)
                    {
                        Console.WriteLine("\n Bạn đã nhập quá 3 lần");
                        Console.WriteLine("\n Mời bạn nhấn lại thẻ");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("\nNHẬP SAI! MỜI NHẬP LẠI!\n");
                    }
                    if (Dem1 != 0 && Dem2 != 0)
                    {
                        Console.WriteLine("\n\t\t------------  Dang Nhap Thanh Cong!  -------------\n");
                        Console.WriteLine("\n\t\t------------  1. Rút tiền  -------------\n");
                        Console.WriteLine("\n\t\t------------  2. Chuyển tiền  -------------\n");
                        Console.WriteLine("\n\t\t------------  3. Kiểm ttra tài khoản  -------------\n");

                        _kqDangNhap = 1;
                    }
                }


            } while (Dem1 == 0 || Dem2 == 0);

             public void nhapThongTin()
        {
            for (int i = 0; i < NTK; i++)
            {
                Console.WriteLine("Nhập ID");
                Arr[i].ID = Console.ReadLine();
                Console.WriteLine("Nhập Password");
                Arr[i].Password = Console.ReadLine();
                Console.WriteLine("Nhập tên Tài khoản");
                Arr[i].TenTK = Console.ReadLine();
                Console.WriteLine("Nhập loại tiền");
                Arr[i].LoaiTien = Console.ReadLine();
                Console.WriteLine("Nhập số dư");
                Arr[i].SoDu = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();

        }

    }
    }

    
}
