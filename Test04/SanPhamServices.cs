using System;
using System.Collections.Generic;
using System.Text;

namespace Test04
{
    public class SanPhamServices
    {
        private List<SanPham> _listSanPham = new List<SanPham>()
        {
            new SanPham {Ma = "SP001", Ten = "Laptop Dell XPS 13", NamBaoHanh = 24, Gia = 1500.0f, SoLuong = 10, DanhMuc = "Laptop"},
            new SanPham {Ma = "SP002", Ten = "Điện thoại Samsung Galaxy S21", NamBaoHanh = 12, Gia = 800.0f, SoLuong = 20, DanhMuc = "Điện thoại" }
        };
        public bool KiemTraMaDaTonTai(string ma)
        {
            return _listSanPham.Any(sp => sp.Ma == ma);
        }
        public bool SuaSanPham(SanPham sanPhamMoi)
        {
            if (sanPhamMoi == null || string.IsNullOrEmpty(sanPhamMoi.Ma)) return false;
            var sanPhamCu = _listSanPham.FirstOrDefault(sp => sp.Ma == sanPhamMoi.Ma);
            if (sanPhamCu == null) return false;
            if(sanPhamMoi.Gia <0 || sanPhamMoi.NamBaoHanh < 0 || sanPhamMoi.SoLuong < 0) return false;

            sanPhamCu.Ten = sanPhamMoi.Ten;
            sanPhamCu.NamBaoHanh = sanPhamMoi.NamBaoHanh;
            sanPhamCu.Gia = sanPhamMoi.Gia;
            sanPhamCu.SoLuong = sanPhamMoi.SoLuong;
            sanPhamCu.DanhMuc = sanPhamMoi.DanhMuc;
            return true;
        }
        public SanPham? GetByMa (string ma)
        {
            return _listSanPham.FirstOrDefault(sp => sp.Ma == ma);
        }
    }
}
