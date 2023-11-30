﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLHoaDon
    {
        DB_CuaHangNoiThatDataContext db = new DB_CuaHangNoiThatDataContext();
        public object GetHoaDon(string values)
        {
            try
            {
                if (values == "")
                {
                    return db.HoaDons.Select(r => new {r.MaHD,r.KhachHang.HoTen,r.NgayLap});
                }
                else
                {
                    return db.HoaDons.Where(r => r.MaKH == values).Select(r => new { r.MaHD, r.KhachHang.HoTen, r.NgayLap });
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool SetTinhTrangHD(string value)
        {
            try
            {
                HoaDon hd = db.HoaDons.Where(r=>r.MaHD== value).FirstOrDefault();
                hd.TinhTrang = true;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public object GetCTHoaDon(string values)
        {
            try
            {
                return db.CTHoaDons.Where(r=>r.MaHD == values).Select(r => new { r.SanPham.TenSP,r.SoLuong});
            }
            catch (Exception)
            {
                return null;
            }
        }
        public HoaDon FindHoaDon(string MaHoaDon)
        {
            try
            {
                return db.HoaDons.Where(r => r.MaHD == MaHoaDon).FirstOrDefault();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool checkID(string id)
        {
            try
            {
                if(db.HoaDons.Where(r=>r.MaHD == id)!= null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool deleteHoaDon(string MaHoaDon)
        {
            try
            {
                HoaDon hd = db.HoaDons.Where(r => r.MaHD == MaHoaDon).FirstOrDefault();
                if (hd != null)
                {
                    List<CTHoaDon> cthds = db.CTHoaDons.Where(r => r.MaHD == MaHoaDon).ToList();
                    foreach (CTHoaDon i in cthds)
                    {
                        db.CTHoaDons.DeleteOnSubmit(i);
                        db.SubmitChanges();
                    }
                    db.HoaDons.DeleteOnSubmit(hd);
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
        public bool insertHoaDon(HoaDon item)
        {
            try
            {
                if (checkID(item.MaHD) == true)
                {
                    db.HoaDons.InsertOnSubmit(item);
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
