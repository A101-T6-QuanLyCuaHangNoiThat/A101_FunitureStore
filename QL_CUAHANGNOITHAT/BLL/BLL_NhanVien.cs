using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_NhanVien
    {
        DB_CuaHangNoiThatDataContext db = new DB_CuaHangNoiThatDataContext();
        public object GetNhanVien()
        {
            return db.NhanViens.Select(r => new { r.MaNV,r.TenNV,r.NgaySinh});
        }
        public NhanVien FindNhanVien(string value)
        {
            return db.NhanViens.Where(r => r.MaNV == value || r.TenNV == value).FirstOrDefault();
        }
        public object GetNhomNguoiDung()
        {
            return db.NhomNguoiDungs.Select(r => r);
        }
        public bool checkID(string ID)
        {
            try
            {
                if (db.NhanViens.Where(r => r.MaNV == ID).FirstOrDefault()!=null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool insertNhanVien(NhanVien nv)
        {
            try
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateNhanVien(NhanVien nv)
        {
            try
            {
                NhanVien updateNV = db.NhanViens.Where(r => r.MaNV == nv.MaNV).FirstOrDefault();
                updateNV.TenNV = nv.TenNV;
                updateNV.CCCD = nv.CCCD;
                updateNV.Email = nv.Email;
                updateNV.NgaySinh = nv.NgaySinh;
                updateNV.DienThoai = nv.DienThoai;
                updateNV.TinhTrang = nv.TinhTrang;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SetRoleNhanVien(string value,string role)
        {
            try
            {
                NhanVien setrole = db.NhanViens.Where(r => r.MaNV == value).FirstOrDefault();
                setrole.MaNhom = role;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteNhanVien(string value)
        {
            try
            {
                NhanVien deleteNV = db.NhanViens.Where(r => r.MaNV == value).FirstOrDefault();
                db.NhanViens.DeleteOnSubmit(deleteNV);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
