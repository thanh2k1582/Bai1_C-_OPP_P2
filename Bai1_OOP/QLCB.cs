using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_OOP
{
    class QLCB
    {
        private List<CongNhan> ListCongnhan = null;
        private List<KySu> ListKySu = null;
        private List<NhanVien> ListNhanVien = null;

        public QLCB()
        {
            ListCongnhan = new List<CongNhan>();
            ListKySu = new List<KySu>();
            ListNhanVien = new List<NhanVien>();
        }


        public void NhapCN()
        {
            CongNhan cn = new CongNhan();
            Console.Write("Nhap ten Cong nhan: ");
            cn.Ten = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi Cong nhan: ");
            cn.Tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap gioi tinh Cong nhan: ");
            cn.Gioitinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap dia chi Cong nhan: ");
            cn.Diachi = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap cap bac Cong nhan(1-10): ");
            cn.Capbac = Convert.ToInt32(Console.ReadLine());

            ListCongnhan.Add(cn);
        }
        public List<CongNhan> timTheoHoTenCN(String keyword)
        {
            List<CongNhan> searchResult = new List<CongNhan>();
            foreach (CongNhan cn in ListCongnhan)
            {
                if (cn.Ten.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(cn);
                }
            }
            return searchResult;
        }
        public void XuatCN(List<CongNhan> listCN)
        {
           foreach (CongNhan cn in listCN)
              {
                Console.WriteLine("Ten cong nhan: {0}", cn.Ten);
                Console.WriteLine("Tuoi cong nhan: {0}", cn.Tuoi);
                Console.WriteLine("Gioi tinh cong nhan: {0}", cn.Gioitinh);
                Console.WriteLine("Dia chi cong nhan: {0}", cn.Diachi);
                Console.Write("Cap bac cong nhan: {0}", cn.Capbac);
            }
            Console.WriteLine();
        }
        public List<CongNhan> getListCongNhan()
        {
            return ListCongnhan;
        }



        public void NhapKS()
        {
            KySu ks = new KySu();
            Console.Write("Nhap ten Ky su: ");
            ks.Ten = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi Ky su: ");
            ks.Tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap gioi tinh Ky su: ");
            ks.Gioitinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap dia chi Ky su: ");
            ks.Diachi = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap nganh dao tao cua ky su: ");
            ks.NganhDaoTao = Convert.ToString(Console.ReadLine());

            ListKySu.Add(ks);
        }
        public List<KySu> timTheoHoTenKS(String keyword)
        {
            List<KySu> searchResult = new List<KySu>();
            foreach (KySu ks in ListKySu)
            {
                if (ks.Ten.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(ks);
                }
            }
            return searchResult;
        }
        public void XuatKS(List<KySu> listKS)
        {
            foreach (KySu ks in listKS)
            {
                Console.WriteLine("Ten Ky su: {0}", ks.Ten);
                Console.WriteLine("Tuoi Ky su: {0}", ks.Tuoi);
                Console.WriteLine("Gioi tinh Ky su: {0}", ks.Gioitinh);
                Console.WriteLine("Dia chi Ky su: {0}", ks.Diachi);
                Console.Write("Nganh dao tao ky su: {0}", ks.NganhDaoTao);
            }
            Console.WriteLine();
        }
        public List<KySu> getListKySu()
        {
            return ListKySu;
        }



        public void NhapNV()
        {
            NhanVien nv = new NhanVien();
            Console.Write("Nhap ten Nhan vien: ");
            nv.Ten = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi Nhan vien: ");
            nv.Tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap gioi tinh Nhan vien: ");
            nv.Gioitinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap dia chi Nhan vien: ");
            nv.Diachi = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap cong viec cua nhan vien: ");
            nv.Congviec = Convert.ToString(Console.ReadLine());

            ListNhanVien.Add(nv);
        }
        public List<NhanVien> timTheoHoTenNV(String keyword)
        {
            List<NhanVien> searchResult = new List<NhanVien>();
            foreach (NhanVien nv in ListNhanVien)
            {
                if (nv.Ten.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(nv);
                }
            }
            return searchResult;
        }
        public void XuatNV(List<NhanVien> listNV)
        {
            foreach (NhanVien nv in listNV)
            {
                Console.WriteLine("Ten Nhan vien: {0}", nv.Ten);
                Console.WriteLine("Tuoi Nhan vien: {0}", nv.Tuoi);
                Console.WriteLine("Gioi tinh Nhan vien: {0}", nv.Gioitinh);
                Console.WriteLine("Dia chi Nhan vien: {0}", nv.Diachi);
                Console.Write("Cong viec nhan vien: {0}", nv.Congviec);
            }
            Console.WriteLine();
        }
        public List<NhanVien> getListNhanVien()
        {
            return ListNhanVien;
        }
    }
}
