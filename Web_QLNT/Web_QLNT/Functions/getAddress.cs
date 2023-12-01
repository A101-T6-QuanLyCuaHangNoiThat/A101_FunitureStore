using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_QLNT.Functions
{
    public class getAddress
    {
        public static string getAdd(string soNha, string duong, string phuong, string quan, string thanhpho)
        {
            return soNha + " " + duong + ", " + phuong + ", " + quan + ", " + ", " + thanhpho + ".";
        }
    }
}