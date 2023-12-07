using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_User
    {
        DB_CuaHangNoiThatDataContext db = new DB_CuaHangNoiThatDataContext();
        NhanVien nv = null;
        public bool login(string Username, string Userpass)
        {
            if (Username == "" || Username == null) return false;
            else if (Userpass == "" || Userpass == null) return false;
            else
            {
                if (db.NhanViens.Where(r => r.MaNV == Username && r.MatKhau == Userpass).FirstOrDefault() != null)
                {
                    if (db.NhanViens.Where(r => r.MaNV == Username && r.MatKhau == Userpass).Select(r => r.MaNhom).FirstOrDefault() == "Gue")
                    {
                        return false;
                    }
                    nv = db.NhanViens.Where(r => r.MaNV == Username && r.MatKhau == Userpass).FirstOrDefault();
                    return true;
                }
            }
            return false;
        }
        public NhanVien GetNhanVien()
        {
            return nv;
        }
    }
}
