namespace Test04.Test;

[TestFixture]
public class TinhToanTest
{
    public TinhToan tinhToan = null!;

    [SetUp]
    public void Setup()
    {
        tinhToan = new TinhToan();
    }

    [Test]
    public void KiemTraChanLe_SoChanDuong_ReturnTrue()
    {
       Assert.That(tinhToan.KiemTraSoChanLe(2), Is.True);
    }
    [Test]
    public void KiemTraChanLe_SoChanAm_ReturnTrue()
    {
        Assert.That(tinhToan.KiemTraSoChanLe(-2), Is.True);
    }
    [Test]
    public void KiemTraChanLe_SoLeDuong_ReturnFalse()
    {
        Assert.That(tinhToan.KiemTraSoChanLe(9), Is.False);
    }
    [Test]
    public void KiemTraChanLe_SoLeAm_ReturnFalse()
    {
        Assert.That(tinhToan.KiemTraSoChanLe(-9), Is.False);
    }
    [Test]
    public void KiemTraChanLe_So0_ReturnTrue()
    {
        Assert.That(tinhToan.KiemTraSoChanLe(0), Is.True);
    }
}
