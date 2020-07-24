using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
     class BankAccount : QLBankAccount
    {
        //fields
        private string m_ID;
        private string m_Password;
        private string m_TenTK;
        private string m_loaiTien;
        private double _soDu;

        public string ID
        {
            get
            {
                return m_ID;
            }

            set
            {
                m_ID = value;
            }
        }

        public string Password
        {
            get
            {
                return m_Password;
            }

            set
            {
                m_Password = value;
            }
        }

        public string TenTK
        {
            get
            {
                return m_TenTK;
            }

            set
            {
                m_TenTK = value;
            }
        }

        public string LoaiTien
        {
            get
            {
                return m_loaiTien;
            }

            set
            {
                m_loaiTien = value;
            }
        }

        public double SoDu
        {
            get
            {
                return _soDu;
            }

            set
            {
                _soDu = value;
            }
        }

        //constructor mặc định
        public BankAccount()
        {
            ID = "01";
            Password = "123";
            TenTK = "Nhung";
            LoaiTien = "VND";
            SoDu = 0;
        }
        //constructor tham số
        public BankAccount(string id, string password, string tk, string loaiTien, double sodu)
        {
            ID = id;
            Password = password;
            TenTK = tk;
            LoaiTien = loaiTien;
            SoDu = sodu;

        }
        //Consstructor tham so co ddaay du thoong tin
        public BankAccount(string ID, string Password, string TenTK, string loaiTien, double soDu, int nTK, int kqDangNhap, int nVT, string nViTriID, string nViTriPW)
        {
            this.ID = ID;
            this.Password = Password;
            this.TenTK = TenTK;
            this.LoaiTien = loaiTien;
            this.SoDu = soDu;
            this._nTK =nTK;
            this._kqDangNhap =kqDangNhap;
            this._nVT = nVT;
            this._nViTriID = nViTriID;
            this._nViTriPW = nViTriPW;
        }

        public virtual void dangNhapTK(BankAccount[] Arr)
        {
            Console.WriteLine("\n\t\t*************************");
            Console.WriteLine("\n\t\t-----L-O-G-I-N-----");
            Console.WriteLine("\n\t\t*************************");
            int Dem1 = 0;
            int Dem2 = 0;
            int Dem3 = 0;
            NVT = -1;
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
                

            }while (Dem1 == 0 || Dem2 == 0);

        }
         
           
        public int getSoTaiKhoan()
        {
            return NTK;
        }
        public string getID()
        {
            return ID;
        }
        public string getPassword()
        {
            return Password;
        }
        public int getKqDangNhap()
        {
            return KqDangNhap;
        }
        public int getnVT()
        {
            return NVT;
        }
        public double getSoDu()
        {
            return SoDu;
        }
        

    }
    }

