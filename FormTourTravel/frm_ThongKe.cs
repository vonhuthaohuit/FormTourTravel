using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTourTravel
{
    public partial class frm_ThongKe : Form
    {
        ql_tourdulich_ptudtmEntities db = new ql_tourdulich_ptudtmEntities();

        public frm_ThongKe()
        {
            InitializeComponent();
            btn_HienThi.Click += Btn_HienThi_Click;
        }

        private void Btn_HienThi_Click(object sender, EventArgs e)
        {
            fillChart();
        }

        private void fillChart()
        {
            DateTime ngayBatDau = dtp_ngayBatDau.Value;
            DateTime ngayKetThuc = dtp_ngayKetThuc.Value;

            var data = db.hoadons
                .Where(hd => hd.updated_at >= ngayBatDau && hd.updated_at <= ngayKetThuc)
                .GroupBy(hd => hd.updated_at)
                .Select(hd => new
                {
                    ngayLap = hd.Key,
                    tongTien = hd.Sum(h => h.tongsotien)
                })
                .ToList();

            if (data.Any())
            {
                chart1.Series.Clear();

                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Series1")
                {
                    XValueMember = "ngayLap",
                    YValueMembers = "tongTien",
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    IsValueShownAsLabel = true,
                    LabelFormat = "{0:0,0}",
                    LabelForeColor = Color.Red,
                    LabelBackColor = Color.White,
                    BorderWidth = 2,
                    MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle,
                    MarkerSize = 10,
                    MarkerColor = Color.Red
                };

                chart1.Series.Add(series);

                var filteredData = new List<dynamic>
        {
            new { ngayLap = ngayBatDau.ToString("dd/MM/yyyy"), tongTien = data.FirstOrDefault()?.tongTien ?? 0 }, // Ngày bắt đầu
            new { ngayLap = ngayKetThuc.ToString("dd/MM/yyyy"), tongTien = data.LastOrDefault()?.tongTien ?? 0 }  // Ngày kết thúc
        };

                chart1.DataSource = filteredData;
                chart1.DataBind();

                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.Title = "Ngày lập";
                chart1.ChartAreas[0].AxisY.Title = "Tổng tiền";

                chart1.Titles.Clear();
                chart1.Titles.Add($"Thống kê từ {ngayBatDau:dd/MM/yyyy} đến {ngayKetThuc:dd/MM/yyyy}");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }

    }
}
