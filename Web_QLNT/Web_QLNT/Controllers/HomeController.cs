using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_QLNT.Models;
using Web_QLNT.Functions;
using System.IO;
using Accord.MachineLearning.Rules;

namespace Web_QLNT.Controllers
{
    public class HomeController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        #region Trang Chủ
        public ActionResult Index(int id)
        {
            ViewBag.NCC = db.NhaCungCaps.ToList();
            ViewBag.Page = id;
            ViewBag.Count = db.SanPhams.Count();
            GioHang cart = Session["Cart"] as GioHang;
            if (cart == null)
            {
                cart = new GioHang();
                Session["Cart"] = cart;
            }
            return View(db.SanPhams.Skip(8 * (id-1)).Take(8).ToList());
        }
        #endregion

        #region Quản Lý Sản Phẩm

        #region Lấy Danh Sách Theo Loại
        public ActionResult GetSP(int id)
        {
            ViewBag.NCC = db.NhaCungCaps.ToList();
            ViewBag.Page = 1;
            ViewBag.Count = db.SanPhams.Where(t => t.MaLoai == id).Count();
            return View("Index", db.SanPhams.Where(t => t.MaLoai == id).ToList());
        }
        #endregion

        #region Xem Chi Tiết Sản Phẩm
        public ActionResult Details(string id)
        {
            ViewBag.NCC = db.NhaCungCaps.ToList();
            ViewBag.Loai = db.Loais.ToList();
            return View(db.SanPhams.Where(t => t.MaSP == id).FirstOrDefault());
        }

        #endregion

        #region AI
        //public ActionResult Details(string id)
        //{
        //    Apriori_U ap = new Apriori_U();
        //    List<HoaDon> dshd = db.HoaDons.ToList();
        //    List<CToHD> dsct = new List<CToHD>();
        //    foreach (HoaDon item in dshd)
        //    {
        //        CToHD ct = new CToHD();
        //        ct.Hd = db.HoaDons.Where(t => t.MaHD == id).FirstOrDefault();
        //        ct.Ds = db.CTHoaDons.Where(t => t.MaHD == id).ToList();
        //        dsct.Add(ct);
        //    }
        //    AssociationRule<string>[] rl = ap.doApriori(dsct);
        //    List<AssociationRule<string>> dskq = new List<AssociationRule<string>>();
        //    foreach (AssociationRule<string> item in rl)
        //    {
        //        if (item.X.ToString()=="["+id+"]")
        //        {
        //            dskq.Add(item);
        //        }
        //    }
        //    ViewBag.NCC = db.NhaCungCaps.ToList();
        //    ViewBag.Loai = db.Loais.ToList();
        //    return View(db.SanPhams.Where(t => t.MaSP == id).FirstOrDefault());
        //}
        #endregion

        #endregion

        #region Quản Lý Bán Hàng
        public ActionResult AddToCart(string id)
        {
            try
            {
                SanPham product = db.SanPhams.Where(t => t.MaSP == id).FirstOrDefault();
                // Lấy giỏ hàng từ Session
                GioHang cart = Session["Cart"] as GioHang;
                if (cart == null)
                {
                    cart = new GioHang();
                }

                cart.AddToCart(product, 1);

                Session["Cart"] = cart;

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult AddToCart(string id, FormCollection f)
        {
            try
            {
                SanPham product = db.SanPhams.Where(t => t.MaSP == id).FirstOrDefault();
                // Lấy giỏ hàng từ Session
                GioHang cart = Session["Cart"] as GioHang;
                if (cart == null)
                {
                    cart = new GioHang();
                }
                string x = f["quantity"];
                cart.AddToCart(product, int.Parse(f["quantity"]));

                Session["Cart"] = cart;

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("ViewCart");
            }
        }

        public ActionResult ViewCart()
        {
            GioHang cart = Session["Cart"] as GioHang;
            if (cart == null)
            {
                cart = new GioHang();
            }
            return View();
        }

        public ActionResult RemoveFromCart(string productId)
        {
            GioHang cart = Session["Cart"] as GioHang;
            if (cart != null)
            {
                cart.RemoveFromCart(productId);
                Session["Cart"] = cart;
            }

            return RedirectToAction("ViewCart");
        }

        public ActionResult ClearCart()
        {
            GioHang cart = Session["Cart"] as GioHang;
            if (cart != null)
            {
                cart.ClearCart();
                Session["Cart"] = cart;
            }

            return RedirectToAction("ViewCart");
        }


        #endregion

        #region Đăng Nhập
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (IsValidUser(username, password))
            {
                KhachHang kh = db.KhachHangs.Where(t => t.MaKH == username).FirstOrDefault();
                Session["KhachHang"] = kh;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng.";
                return View();
            }
        }

        private bool IsValidUser(string username, string password)
        {
            KhachHang kh = db.KhachHangs.Where(t => t.MaKH == username).FirstOrDefault();
            if (kh == null)
                return false;
            return password == kh.MatKhau;
        }
        #endregion

        #region Đăng Xuất
        public ActionResult Logout()
        {
            Session.Remove("KhachHang");
            return RedirectToAction("Index");
        }
        #endregion

        #region Đăng Ký
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection f, HttpPostedFileBase fUpLoad)
        {
            if (f["MatKhau"] != f["ReMatKhau"])
            {
                ViewBag.ErrorMessage = "Mật khẩu nhập không trùng khớp";
                return View();
            }
            KhachHang kh = new KhachHang();
            kh.MaKH = f["MaKH"];
            kh.HoTen = f["HoTen"];
            kh.Email = f["Email"];
            if (f["Email"].ToString().Contains("@") && (f["Email"].ToString().Contains(".com")))
            {
                kh.Email = f["Email"];
            }
            else
            {
                ViewBag.ErrorMessage = "Email không hợp lệ.";
                return View();
            }
            kh.NgaySinh = DateTime.ParseExact(f["NgaySinh"], "yyyy-MM-dd", CultureInfo.InvariantCulture);
            kh.DienThoai = f["DienThoai"];
            kh.DiaChi = getAddress.getAdd(f["SoNha"], f["Duong"], f["Phuong"], f["Quan"], f["ThanhPho"]);
            kh.MatKhau = f["MatKhau"];
            kh.MaNhom = "Gue";
            kh.TinhTrang = "Active";
            if (fUpLoad != null && fUpLoad.ContentLength > 0)
            {
                // Lấy tên file
                string fileName = Path.GetFileName(fUpLoad.FileName);

                // Lưu file vào thư mục trên server
                string path = Path.Combine(Server.MapPath("~/Images"), f["MaKH"]+".jpg");
                fUpLoad.SaveAs(path);
                kh.HinhAnh = f["MaKH"];
            }
            else
            {
                ViewBag.ErrorMessage = "File ảnh không hợp lệ.";
                return View();
            }
            try
            {
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return RedirectToAction("Login", "Home");
            }
            catch (Exception)
            {
                ViewBag.ErrorMessage = "Tên đăng nhập đã được sử dụng.";
                return View();
            }
        }
        #endregion

        #region Quản Lý Khách Hàng (Thêm, Xóa, Sửa)

        #region Chỉnh sửa Thông Tin
        public ActionResult EditKH()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditKH(String id, FormCollection f, HttpPostedFileBase fUpLoad)
        {
            KhachHang kh = db.KhachHangs.Where(t => t.MaKH == id).FirstOrDefault();
            kh.HoTen = f["HoTen"];
            kh.Email = f["Email"];
            if (f["Email"].ToString().Contains("@") && (f["Email"].ToString().Contains(".com")))
            {
                kh.Email = f["Email"];
            }
            else
            {
                ViewBag.ErrorMessage = "Email không hợp lệ.";
                return View();
            }
            kh.NgaySinh = DateTime.ParseExact(f["NgaySinh"], "yyyy-MM-dd", CultureInfo.InvariantCulture);
            kh.DienThoai = f["DienThoai"];
            kh.DiaChi = f["DiaChi"];
            if (fUpLoad != null && fUpLoad.ContentLength > 0)
            {
                // Lấy tên file
                string fileName = Path.GetFileName(fUpLoad.FileName);

                // Lưu file vào thư mục trên server
                string name = id;
                while (kh.HinhAnh == name+".jpg")
                {
                    name += 1;
                }
                string path = Path.Combine(Server.MapPath("~/Images"), name + ".jpg");
                fUpLoad.SaveAs(path);
                kh.HinhAnh = name + ".jpg";
            }
            try
            {
                db.SubmitChanges();
                Session["KhachHang"] = kh;
                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View();
            }
        }
        #endregion

        #region Đổi Mật Khẩu
        public ActionResult changePassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult changePassword(String id, FormCollection f)
        {
            if (f["MatKhauMoi"] != f["ReMatKhauMoi"])
            {
                ViewBag.ErrorMessage = "Mật khẩu nhập không trùng khớp";
                ViewBag.Ma = id;
                return View();
            }
            KhachHang kh = db.KhachHangs.Where(t => t.MaKH == id).FirstOrDefault();
            if (f["MatkhauCu"] == kh.MatKhau)
            {
                kh.MatKhau = f["MatKhauMoi"];
                db.SubmitChanges();
                Session["KhachHang"] = kh;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Mật khẩu cũ không chính xác.";
                ViewBag.Ma = id;
                return View();
            }
        }
        #endregion

        #region Xóa Tài Khoản
        public ActionResult deleteKH(String id)
        {
            KhachHang kh = db.KhachHangs.Where(t => t.MaKH == id).FirstOrDefault();
            try
            {
                db.KhachHangs.DeleteOnSubmit(kh);
                db.SubmitChanges();
                Logout();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion

        #endregion


    }
}