using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accord.MachineLearning;
using Accord.Statistics.Filters;

namespace ThuVien.Code
{
    public class ThuatToan
    {
        private KMeansClusterCollection clusters;
        private Codification codebook;

        public void TrainKMeans(DataGridView dataGridView)
        {
            var data = dataGridView.Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new
                {
                    tourId = Convert.ToInt32(row.Cells["tour_id"].Value),
                    giaTour = Convert.ToDouble(row.Cells["giatour"].Value),
                    giaGiam = Convert.ToDouble(row.Cells["giagiam"].Value),
                    noiKhoiHanh = row.Cells["noikhoihanh"].Value.ToString(),
                    maKhuyenMai = Convert.ToInt32(row.Cells["makhuyenmai"].Value),
                    tongKhachHangTour = Convert.ToInt32(row.Cells["tongkhachhangtour"].Value),
                    tongSoTien = Convert.ToDouble(row.Cells["tongsotien"].Value),
                })
                .ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("tour_id", typeof(double));
            dataTable.Columns.Add("giaTour", typeof(double));
            dataTable.Columns.Add("giaGiam", typeof(double));
            dataTable.Columns.Add("noiKhoiHanh", typeof(string));
            dataTable.Columns.Add("maKhuyenMai", typeof(double));
            dataTable.Columns.Add("tongKhachHangTour", typeof(double));
            dataTable.Columns.Add("tongSoTien", typeof(double));

            foreach (var row in data)
            {
                dataTable.Rows.Add(
                    row.tourId,
                    row.giaTour,
                    row.giaGiam,
                    row.noiKhoiHanh,
                    row.maKhuyenMai,
                    row.tongKhachHangTour,
                    row.tongSoTien
                );
            }

            codebook = new Codification(dataTable);
            DataTable codifiedData = codebook.Apply(dataTable);


            // Bước 3: Chuẩn bị dữ liệu cho KMeans
            double[][] numericalData = codifiedData.AsEnumerable()
                    .Select(row => new double[]
                    {
                        Convert.ToDouble(row["giaTour"]),
                        Convert.ToDouble(row["giaGiam"]),
                        Convert.ToDouble(row["noiKhoiHanh"]),
                        Convert.ToDouble(row["maKhuyenMai"]),
                        Convert.ToDouble(row["tongKhachHangTour"]),
                        Convert.ToDouble(row["tongsotien"])
                    })
                    .ToArray();


            // Bước 4: Chuẩn hóa dữ liệu
            var normalizer = new Accord.Statistics.Filters.Normalization();
            double[][] normalizedData = normalizer.Apply(numericalData);

            // Bước 5: Huấn luyện mô hình KMeans
            KMeans kmeans = new KMeans(k: 2); // Số cụm là 2
            clusters = kmeans.Learn(normalizedData);

            // Bước 6: Lấy nhãn cụm và trung tâm cụm
            var clusterCenters = clusters.Centroids; // Tọa độ trung tâm cụm
            int[] labels = clusters.Decide(normalizedData);

            // Debug: In thông tin cụm
            for (int i = 0; i < labels.Length; i++)
            {
                Console.WriteLine($"Tour {i}: Thuộc cụm {labels[i]}");
            }
        }

        public int kiemthu(double[] customerData)
        {
            if (clusters == null)
                throw new InvalidOperationException("Model chưa được huấn luyện.");

            return clusters.Decide(customerData);
        }
    }
}
