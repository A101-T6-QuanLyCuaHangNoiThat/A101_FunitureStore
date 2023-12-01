using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_QLNT.Models
{
    public class CToHD
    {
        private HoaDon hd;
        List<CTHoaDon> ds;
        public HoaDon Hd { get => hd; set => hd = value; }
        public List<CTHoaDon> Ds { get => ds; set => ds = value; }

        public CToHD()
        {

        }

        public string[] layCTHD()
        {
            string[] d = null;
            int i = 0;
            foreach (CTHoaDon item in Ds)
            {
                d[i] = item.MaSP;
                i++;
            }
            return d;
        }
    }
}