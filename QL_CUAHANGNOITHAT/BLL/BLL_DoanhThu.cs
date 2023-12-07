using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DoanhThu
    {
        DB_CuaHangNoiThatDataContext db = new DB_CuaHangNoiThatDataContext();
        public double TongThuNhap()
        {
            return double.Parse(db.HoaDons.Select(r => r.TongTien).Sum().ToString());
        }
        public double TotalSpending()
        {
            return double.Parse(db.PhieuNhaps.Select(r => r.TongTien).Sum().ToString());
        }
        public int CountClient()
        {
            return int.Parse(db.KhachHangs.Select(r => r.MaKH).Count().ToString());
        }
        public object getHoaDon()
        {
            return db.HoaDons.Select(r => new { r.KhachHang.HoTen,r.KhachHang.DienThoai, r.NgayLap, r.TongTien });
        }
    }
}
