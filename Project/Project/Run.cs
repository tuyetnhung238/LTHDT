using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Run
    {
        public void NhapTTTK(BankAccount[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
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
        }
    }
}
