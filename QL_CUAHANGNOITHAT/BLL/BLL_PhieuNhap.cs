using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PhieuNhap
    {
        DB_CuaHangNoiThatDataContext db = new DB_CuaHangNoiThatDataContext();
        public object GetPhieuNhap(string values)
        {
            if(values == "")
            {
                return db.PhieuNhaps.Select(r => r);
            }
            else
            {
                return db.PhieuNhaps.Where(r=>r.NhanVien.TenNV == values).Select(r => new {r.MaPN,r.NgayLap,r.TongTien});
            }
        }
        public PhieuNhap FindPhieuNhap(string values)
        {
            return db.PhieuNhaps.Where(r=>r.MaPN == values).FirstOrDefault();
        }
        public object GetCTPhieuNhap(string values)
        {
            return db.CTPhieuNhaps.Where(r=>r.MaPN == values).Select(r => new {r.SanPham.TenSP,r.SoLuong});
        }
        public bool deletePhieuNhap(string values)
        {
            try
            {
                List<CTPhieuNhap> ctpns = db.CTPhieuNhaps.Where(r => r.MaPN == values).Select(r=>r).ToList();
                foreach(CTPhieuNhap i in ctpns)
                {
                    db.CTPhieuNhaps.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }
                PhieuNhap pn = db.PhieuNhaps.Where(r => r.MaPN == values).FirstOrDefault();
                db.PhieuNhaps.DeleteOnSubmit(pn);
                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool checkID(string values)
        {
            if(db.PhieuNhaps.Where(r=>r.MaPN == values).FirstOrDefault() != null)
            {
                return false;
            }
            return true;
        }
        public bool insertPhieuNhap(PhieuNhap pn)
        {
            try
            {
                if (checkID(pn.MaPN) == true)
                {
                    db.PhieuNhaps.InsertOnSubmit(pn);
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
        public bool insertCTPhieuNhap(CTPhieuNhap pn)
        {
            try
            {
                pn.MaCT = ""+(db.PhieuNhaps.Count() + 1);
                db.CTPhieuNhaps.InsertOnSubmit(pn);
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
