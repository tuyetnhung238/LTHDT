using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class UserTransaction : BankAccount
    {
        private double m_soTienRut;
        private double m_soDu;
        private double m_soDuMoi;
        private int m_id;
        private double m_soTienChuyen;

        public double SoTienRut
        {
            get
            {
                return m_soTienRut;
            }

            set
            {
                m_soTienRut = value;
            }
        }

        public double SoDu1
        {
            get
            {
                return m_soDu;
            }

            set
            {
                m_soDu = value;
            }
        }

        public double SoDuMoi
        {
            get
            {
                return m_soDuMoi;
            }

            set
            {
                m_soDuMoi = value;
            }
        }

        public int Id
        {
            get
            {
                return m_id;
            }

            set
            {
                m_id = value;
            }
        }

        public double SoTienChuyen
        {
            get
            {
                return m_soTienChuyen;
            }

            set
            {
                m_soTienChuyen = value;
            }
        }
        //consstructor mac dinh
        public UserTransaction()
        {
            m_id = 1;
            m_soDu = 50000;
            m_soDuMoi = 10000;
            m_soTienChuyen = 123333;
            m_soTienRut = 5000000;
        }
        //consstructor tham so
        public UserTransaction(double soTienRut, double soDu, double soDuMoi, int id, double soTienChuyen)
        {
            this.m_soTienRut = soTienRut;
            this.m_soDu = soDu;
            this.m_soDuMoi = soDuMoi;
            this.m_id = id;
            this.m_soTienChuyen = soTienChuyen;
        }
        //nhap tiền rút
        public void nhapTienRut()
        {
            Console.WriteLine("\t\t\t* * * * * * * * * * * * * * * * * *\n");
            Console.WriteLine("\t\t\t* * * * *RÚT TIỀN * * * * * *\n");
            Console.WriteLine("\t\t\t* * * * * * * * * * * * * * * * * *\n");
            Console.WriteLine("n\t Số dư hiện tại của bạn là:");
        }

        public void rutTien()
        {
            nhapTienRut();
            double tienRut;
            double tienCon;
            do
            {
                Console.WriteLine("\n Nhập số tiền cần rút:");
                tienRut = double.Parse(Console.ReadLine());
                tienCon = m_soDu - tienRut;

                if (tienRut < 50000)
                {
                    Console.WriteLine("\n Số tiền cần rút phải từ 50000 trở lên!");
                }
                if (tienCon < 50000)
                {
                    Console.WriteLine("\n Số tiền vượt quá số dư, Nhập lại!");
                }
            }
            while (tienRut < 50000 || tienCon < 50000);
            Console.WriteLine("\n RÚT TIỀN THÀNH CÔNG");
        }
        public void nhapGiaoDich()
        {
            Console.WriteLine("\n\t\t******************************************\n");
            Console.WriteLine("\n\t\t********CHUYỂN TIỀN***********\n");
            Console.WriteLine("\n\t\t******************************************\n");

            Console.WriteLine("\nNhập tài khoản: ");
            m_id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNhập số tiền cần chuyển: ");
            m_soTienChuyen = double.Parse(Console.ReadLine());

            if (m_soTienChuyen <= m_soDu)
            {
                Console.WriteLine("BẠN ĐÃ CHUYỂN THÀNH CÔNG{0} VND CHO TAI KHOAN{1}", m_soTienChuyen, m_id);
                Console.WriteLine("SỐ DƯ CÒN LẠI LÀ:{0} VND\n\n", m_soDu - m_soTienChuyen);
            }
            while (m_soTienChuyen > m_soDu)
            {
                Console.WriteLine("\nSố tiền chuyển phải nhỏ hơn hoặc bằng số dư còn lại!");
                m_soTienRut = double.Parse(Console.ReadLine());
                if (m_soTienChuyen <= m_soDu)
                {
                    Console.WriteLine("BẠN ĐÃ CHUYỂN THÀNH CÔNG{0} VND CHO TAI KHOAN{1}", m_soTienChuyen, m_id);
                    Console.WriteLine("SỐ DƯ CÒN LẠI LÀ:{0} VND\n\n", m_soDu - m_soTienChuyen);
                }

            }
        }
        public double getSoTienChuyen()
        {
            return m_soTienChuyen;

        }
        public int getiD()
        {
            return m_id;
        }
        public double getSoTienRut()
        {
            return m_soTienRut;
        }
        public double getsoDu()
        {
            return m_soDu;
        }
    }
}
