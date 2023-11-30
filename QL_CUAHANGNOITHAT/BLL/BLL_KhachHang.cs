using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_KhachHang
    {
        DB_CuaHangNoiThatDataContext db = new DB_CuaHangNoiThatDataContext();

        public object GetKhachHang()
        {
            return db.KhachHangs.Select(r => new { r.MaKH,r.HoTen, r.Email, r.NgaySinh, r.DienThoai, r.DiaChi });
        }
        public KhachHang FindKhachHang(string value)
        {
            try
            {
                return db.KhachHangs.Where(r => r.MaKH == value || r.HoTen == value).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool DelKhachHang(string value)
        {
            try
            {
                if(FindKhachHang(value)!=null){
                   KhachHang kh = FindKhachHang(value);
                   db.KhachHangs.DeleteOnSubmit(kh);
                   db.SubmitChanges();
                   return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool EditKhachHang(KhachHang item)
        {
            try
            {
                if (FindKhachHang(item.MaKH) != null)
                {
                    KhachHang editKhachHang = FindKhachHang(item.MaKH);
                    editKhachHang.HoTen = item.HoTen;
                    editKhachHang.Email = item.Email;
                    editKhachHang.NgaySinh = item.NgaySinh;
                    editKhachHang.DiaChi = item.DiaChi;
                    editKhachHang.DienThoai = item.DienThoai;
                    editKhachHang.TinhTrang = item.TinhTrang;

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
