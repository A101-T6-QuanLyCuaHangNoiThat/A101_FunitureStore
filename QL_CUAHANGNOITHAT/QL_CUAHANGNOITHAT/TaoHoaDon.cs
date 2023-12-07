using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QL_CUAHANGNOITHAT
{
    public partial class TaoHoaDon : Form
    {
        BLLHoaDon hd = new BLLHoaDon();
        BLL_SanPham sp = new BLL_SanPham();
        public NhanVien UserAccout { get; set; }
        public TaoHoaDon(NhanVien UserAccout)
        {
            this.UserAccout = UserAccout;
            InitializeComponent();
        }

        private void TaoHoaDon_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {

            dtSanPham.DataSource = sp.GetSanPham(0);
            dtChiTietPhieuNhap.Columns.Add("Column1", "Tên sản phẩm");
            dtChiTietPhieuNhap.Columns.Add("Column2", "Số lượng bán");
            dtChiTietPhieuNhap.Columns.Add("Column3", "Đơn giá");
            Random random = new Random();
            string IDSP = "HD" + random.Next(10000, 99999);
            while (hd.checkID(IDSP) == true)
            {
                IDSP = "HD" + random.Next(10000, 99999);
            }
            txtMaPN.Text = IDSP;
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTenNV.Text = UserAccout.TenNV;
        }
        List<cart> list = new List<cart>();

        public List<cart> push(string MaSP, string TenSP, int SoLuong, int DonGia)
        {
            if (list.Count() == 0)
            {
                cart c = new cart();
                c.MaSP = MaSP;
                c.TenSP = TenSP;
                c.SoLuong = SoLuong;
                c.DonGia = DonGia;
                list.Add(c);
            }
            else
            {
                if (list.Where(r => r.MaSP == MaSP).FirstOrDefault() == null)
                {
                    cart c = new cart();
                    c.MaSP = MaSP;
                    c.TenSP = TenSP;
                    c.SoLuong = SoLuong;
                    c.DonGia = DonGia;
                    list.Add(c);
                }
                else
                {
                    cart c = list.Where(r => r.MaSP == MaSP).FirstOrDefault();
                    c.SoLuong = SoLuong;
                }
            }
            return list;
        }
        private void dtSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dtSanPham.SelectedCells[0].RowIndex;
            string selectedValue = dtSanPham.Rows[selectedRowIndex].Cells[0].Value.ToString();

            SanPham item = sp.FindSanPham(selectedValue);
            if (item != null)
            {
                txtMaSP.Text = item.MaSP;
                txtSoLuong.Text = item.SoLuongTon.ToString();
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (sp.checkSLTon(txtMaSP.Text) == 0 || sp.checkSLTon(txtMaSP.Text) < int.Parse(txtSLNhap.Text))
            {
                MessageBox.Show("Số lượng sản phẩm không đủ");
            }
            else
            {
                if (dtChiTietPhieuNhap.Rows.Count > 0)
                {
                    dtChiTietPhieuNhap.Rows.Clear();
                    SanPham item = sp.FindSanPham(txtMaSP.Text);
                    if (item != null)
                    {
                        //int soluongNhap = int.Parse(txtSoLuong.Text) - int.Parse(item.SoLuongTon.ToString());
                        push(item.MaSP, item.TenSP, int.Parse(txtSLNhap.Text), int.Parse(item.DonGia.ToString()));
                    }
                }
                double total = 0;
                foreach (var i in list)
                {
                    dtChiTietPhieuNhap.Rows.Add(i.TenSP, i.SoLuong,i.DonGia);
                    total += (i.DonGia * i.SoLuong * 1.0);
                }
                txtTongTien.Text = total.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận nhập hàng", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Tạo mới 1 khách hàng khi mua trực tiệp tại cửa hàng : Lưu thông tin (Tên khách hàng , sdt , địa chỉ)
                KhachHang kh = new KhachHang();
                Random random = new Random();
                string IDKH = "KH" + random.Next(10000, 99999);
                while (hd.checkIDKLH(IDKH) == true)
                {
                    IDKH = "KH" + random.Next(10000, 99999);
                }
                kh.MaKH = IDKH;
                kh.HoTen = txtTenKH.Text;
                kh.DienThoai = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                hd.insertKhachHangTemp(kh);

                //tạo mới 1 hoá đơn và chi tiết hoá đơn
                HoaDon insertHoaDon = new HoaDon();
                insertHoaDon.MaHD = txtMaPN.Text;
                insertHoaDon.NgayLap = DateTime.Parse(txtNgayLap.Text);
                insertHoaDon.MaNV = UserAccout.MaNV;
                insertHoaDon.MaKH = kh.MaKH;
                insertHoaDon.TinhTrang = false;
                insertHoaDon.TongTien = int.Parse(txtTongTien.Text);
                hd.insertHoaDon(insertHoaDon);
                foreach (var i in list)
                {
                    CTHoaDon cthd = new CTHoaDon();
                    cthd.MaCT = (hd.CountCTHD() + 1);
                    cthd.MaHD = txtMaPN.Text;
                    cthd.MaSP = i.MaSP;
                    cthd.SoLuong = i.SoLuong;
                    hd.insertCTHoaDon(cthd);
                }
                MessageBox.Show("Tạo hoá đơn thành công");
            }
            else
            {
                return;
            }
        }

    }

}
