using System;
using System.Collections.Generic;

namespace Bai1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            QLCB quanLyCanBo = new QLCB();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY CAN BO");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them can bo.                                  **");
                Console.WriteLine("**  2. Tim kiem can bo theo ho ten.                  **");
                Console.WriteLine("**  3. Hien thi danh sach can bo.                    **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them can bo.");
                        Console.WriteLine("**  1. Them Cong nhan.                               **");
                        Console.WriteLine("**  2. Them Ky su.                                   **");
                        Console.WriteLine("**  3. Them Nhan vien.                               **");
                        Console.Write("Nhap tuy chon: ");
                        int select1 = Convert.ToInt32(Console.ReadLine());
                        switch (select1)
                        {
                            case 1:
                                quanLyCanBo.NhapCN();
                                Console.WriteLine("\nThem cong nhan thanh cong!");
                                break;
                            case 2:
                                quanLyCanBo.NhapKS();
                                Console.WriteLine("\nThem ky su thanh cong!");
                                break;
                            case 3:
                                quanLyCanBo.NhapNV();
                                Console.WriteLine("\nThem nhan vien thanh cong!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n4. Tim kiem sinh vien theo ten.");
                        Console.WriteLine("\n1. Tim kiem.");
                        Console.WriteLine("**  1. Tim kiem Cong nhan theo ten.                  **");
                        Console.WriteLine("**  2. Tim kiem Ky su theo ten.                      **");
                        Console.WriteLine("**  3. TTim kiem Nhan vien theo ten.                 **");
                        Console.Write("Nhap tuy chon: ");
                        int select2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nNhap ten de tim kiem: ");
                        string name = Convert.ToString(Console.ReadLine());
                        switch (select2)
                        {
                            case 1:
                                List<CongNhan> searchResult1 = quanLyCanBo.timTheoHoTenCN(name);
                                quanLyCanBo.XuatCN(searchResult1);
                                break;
                            case 2:
                                List<KySu> searchResult2 = quanLyCanBo.timTheoHoTenKS(name);
                                quanLyCanBo.XuatKS(searchResult2);
                                break;
                            case 3:
                                List<NhanVien> searchResult3 = quanLyCanBo.timTheoHoTenNV(name);
                                quanLyCanBo.XuatNV(searchResult3);
                                break;
                        }
                        break;
                    
                    case 3:
                            quanLyCanBo.XuatCN(quanLyCanBo.getListCongNhan());

                        Console.WriteLine("\n1. Hien thi danh sach can bo.");
                        Console.WriteLine("**  1.Cong nhan.                               **");
                        Console.WriteLine("**  2.Ky su.                                   **");
                        Console.WriteLine("**  3.Nhan vien.                               **");
                        Console.WriteLine("**  4.Tat ca.                                  **");
                        Console.Write("Nhap tuy chon: ");
                        int select3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n7. Hien thi danh sach can bo.");
                        switch (select3)
                        {
                            case 1:
                                quanLyCanBo.XuatCN(quanLyCanBo.getListCongNhan());
                                break;
                            case 2:
                                quanLyCanBo.XuatKS(quanLyCanBo.getListKySu());
                                break;
                            case 3:
                                quanLyCanBo.XuatNV(quanLyCanBo.getListNhanVien());
                                break;
                            case 4:
                                quanLyCanBo.XuatCN(quanLyCanBo.getListCongNhan());
                                quanLyCanBo.XuatKS(quanLyCanBo.getListKySu());
                                quanLyCanBo.XuatNV(quanLyCanBo.getListNhanVien());
                                break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }

        }
    }
}
