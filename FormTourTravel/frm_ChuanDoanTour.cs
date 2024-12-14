using BLL;
using DTO;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Code;

namespace FormTourTravel
{
    public partial class frm_ChuanDoanTour : Form
    {
        ThuatToan ThuatToan = new ThuatToan();
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();
        public frm_ChuanDoanTour()
        {
            InitializeComponent();
            btn_KiemThu.Enabled = false;
            btn_HuanLuyen.Click += Btn_HuanLuyen_Click;
            btn_KiemThu.Click += Btn_KiemThu_Click;
            cbo_MaTour.SelectedIndexChanged += Cbo_MaTour_SelectedIndexChanged;
            dgv_ChuanDoan.CellClick += Dgv_ChuanDoan_CellClick;
        }

        private void Dgv_ChuanDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChuanDoan.Rows[e.RowIndex];
                cbo_MaTour.SelectedValue = row.Cells["tour_id"].Value;

                txt_GiaTour.Text = row.Cells["giatour"].Value?.ToString() ?? "";
                txt_GiaTourGiam.Text = row.Cells["giagiam"].Value?.ToString() ?? "";
                txt_NoiKhoiHanh.Text = row.Cells["noikhoihanh"].Value?.ToString() ?? "";
                txt_KhuyenMai.Text = row.Cells["makhuyenmai"].Value?.ToString() ?? "";
                txt_TongKhachHangDiTour.Text = row.Cells["tongkhachhangtour"].Value?.ToString() ?? "";
                txt_TongSoTien.Text = row.Cells["tongsotien"].Value?.ToString() ?? "";
            }
        }


        private void Cbo_MaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_MaTour.SelectedValue != null)
            {
                int selectedTourId = Convert.ToInt32(cbo_MaTour.SelectedValue); 
                var selectedTour = db.tours
                    .FirstOrDefault(tour => tour.matour == selectedTourId);

                if (selectedTour != null)
                {
                    txt_GiaTour.Text = selectedTour.giatour.ToString();
                    txt_GiaTourGiam.Text = selectedTour.giatourgiam.ToString();
                    txt_NoiKhoiHanh.Text = selectedTour.noikhoihanh.ToString();
                    txt_KhuyenMai.Text = selectedTour.makhuyenmai.ToString();
                }
            }
        }


        private void Btn_KiemThu_Click(object sender, EventArgs e)
        {
            double tour_id = 0;
            double giaTour = 0;
            double giaTourGiam = 0;
            double noiKhoiHanh = 0;
            double khuyenMai = 0;
            double tongKhachHangDiTour = 0;
            double tongSoTien = 0;

            string input = cbo_MaTour.SelectedValue.ToString();
            double.TryParse(input, out tour_id);
            double.TryParse(txt_GiaTour.Text, out giaTour);
            double.TryParse(txt_GiaTourGiam.Text, out giaTourGiam);
            double.TryParse(txt_NoiKhoiHanh.Text, out noiKhoiHanh);
            double.TryParse(txt_KhuyenMai.Text, out khuyenMai);
            double.TryParse(txt_TongKhachHangDiTour.Text, out tongKhachHangDiTour);
            double.TryParse(txt_TongSoTien.Text, out tongSoTien);

            double[] customerData = new double[]
            {
                    giaTour,
                    giaTourGiam,
                    noiKhoiHanh,
                    khuyenMai,
                    tongKhachHangDiTour,
                    tongSoTien
            };

            int cluster = ThuatToan.kiemthu(customerData);

            if (cluster == 1)
            {
                lbl_KetQua.Text = "Tour đang được khách hàng quan tâm";
            }
            else
            {
                lbl_KetQua.Text = "Tour chưa được khách hàng quan tâm";
            }
        }
        public void loadCboTour()
        {
            cbo_MaTour.DisplayMember = "tentour";
            cbo_MaTour.ValueMember = "matour";
            cbo_MaTour.DataSource = db.tours.Select(tour => new
            {
                matour = tour.matour,
                tentour = tour.tentour
            }).ToList();
            
        }

        public void loadDataGirdView()
        {
            var tongKhachHangTour = db.phieudattours
                .GroupBy(pdt => pdt.matour)
                .Select(group => new
                {
                    matour = group.Key,
                    tongSoLuong = group.Sum(pdt => pdt.tongsoluong)
                })
                .ToList();

            var tongSoTien = db.phieudattours
                .GroupBy(pdt => pdt.matour)
                .Select(group => new
                {
                    matour = group.Key,
                    tongSoTien = group.Sum(pdt => pdt.tongtienphieudattour)
                })
                .ToList();

            var tours = db.tours.ToList();

            var data = tours
                .Select(tour => new
                {
                    tour_id = tour.matour,
                    giatour = tour.giatour,
                    giagiam = tour.giatourgiam,
                    noikhoihanh = tour.noikhoihanh,
                    makhuyenmai = tour.makhuyenmai ?? 1,
                    tongkhachhangtour = tongKhachHangTour
                        .FirstOrDefault(tkh => tkh.matour == tour.matour)?.tongSoLuong ?? 0,
                    tongsotien = tongSoTien
                        .FirstOrDefault(tst => tst.matour == tour.matour)?.tongSoTien ?? 0
                })
                .ToList();

            dgv_ChuanDoan.DataSource = data;
        }


        private void Btn_HuanLuyen_Click(object sender, EventArgs e)
        {
            
            ThuatToan.TrainKMeans(dgv_ChuanDoan);
            btn_KiemThu.Enabled = true;
        }

        private void frm_ChuanDoanTour_Load(object sender, EventArgs e)
        {
            loadCboTour();
            loadDataGirdView();
        }
    }
}
