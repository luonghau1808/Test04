namespace Test04.Test;

[TestFixture]
public class SanPhamServiecsTest
{
    private SanPhamServices sanPhamServices = null!;
    [SetUp]
    public void Setup()
    {
        sanPhamServices = new SanPhamServices();
    }

    [Test]
    public void KiemTraMaDaTonTai_True()
    {
        Assert.That(sanPhamServices.KiemTraMaDaTonTai("SP001"), Is.True);
    }
    [Test]
    public void KiemTraMaDaTonTai_False()
    {
        Assert.That(sanPhamServices.KiemTraMaDaTonTai("SP003"), Is.False);
    }
    [Test]
    public void SuaSanPham_HopLe_ReturnTrue()
    {
        var sanPhamMoi = new SanPham { Ma = "SP001", Ten = "Laptop Dell XPS 15", NamBaoHanh = 36, Gia = 2000.0f, SoLuong = 5, DanhMuc = "Laptop" };
        var result = sanPhamServices.SuaSanPham(sanPhamMoi);
        Assert.That(result, Is.True);
        var after = sanPhamServices.GetByMa("SP001");
        Assert.That(after.Ten, Is.EqualTo("Laptop Dell XPS 15"));
        Assert.That(after.NamBaoHanh, Is.EqualTo(36));
        Assert.That(after.Gia, Is.EqualTo(2000.0f));
        Assert.That(after.SoLuong, Is.EqualTo(5));
        Assert.That(after.DanhMuc, Is.EqualTo("Laptop"));

    }
    [Test]
    public void SuaSanPham_SanPhamKhongTonTai_ReturnFalse()
    {
        var sanPhamMoi = new SanPham { Ma = "SP003", Ten = "Máy tính bảng iPad Pro", NamBaoHanh = 12, Gia = 1000.0f, SoLuong = 15, DanhMuc = "Máy tính bảng" };
        var result = sanPhamServices.SuaSanPham(sanPhamMoi);
        Assert.That(result, Is.False);
    }
    [Test]
    public void SuaSanPham_GiaAm_ReturnFalse()
    {
        var sanPhamMoi = new SanPham { Ma = "SP001", Ten = "Laptop Dell XPS 15", NamBaoHanh = 36, Gia = -2000.0f, SoLuong = 5, DanhMuc = "Laptop" };
        var result = sanPhamServices.SuaSanPham(sanPhamMoi);
        Assert.That(result, Is.False);
    }
    [Test]
    public void SuaSanPham_NamBaoHanhAm_ReturnFalse()
    {
        var sanPhamMoi = new SanPham { Ma = "SP001", Ten = "Laptop Dell XPS 15", NamBaoHanh = -36, Gia = 2000.0f, SoLuong = 5, DanhMuc = "Laptop" };
        var result = sanPhamServices.SuaSanPham(sanPhamMoi);
        Assert.That(result, Is.False);
    }
    [Test]
    public void SuaSanPham_SoLuongAm_ReturnFalse()
    {
        var sanPhamMoi = new SanPham { Ma = "SP001", Ten = "Laptop Dell XPS 15", NamBaoHanh = 36, Gia = 2000.0f, SoLuong = -5, DanhMuc = "Laptop" };
        var result = sanPhamServices.SuaSanPham(sanPhamMoi);
        Assert.That(result, Is.False);
    }
    [Test]
    public void SuaSanPham_SanPhamNull_ReturnFalse()
    {
       var result = sanPhamServices.SuaSanPham(null);
        Assert.That(result, Is.False);
        var sp = new SanPham { Ma = "", Ten = "Laptop Dell XPS 15", NamBaoHanh = 36, Gia = 2000.0f, SoLuong = 5, DanhMuc = "Laptop" };
        result = sanPhamServices.SuaSanPham(sp);
        Assert.That(result, Is.False);

    }
   
}
