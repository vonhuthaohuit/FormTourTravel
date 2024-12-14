using BLL;
using DevExpress.XtraEditors;
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
using System.IO;
using DevExpress.Utils.CommonDialogs;
using System.Globalization;
using DevExpress.XtraLayout.Filtering.Templates;

namespace FormTourTravel
{
	public partial class frm_AddTourDX : XtraForm
	{
		private TourTypeBLL tourTypeBLL;
		private KhuyenMaiBLL khuyenMaiBLL;
		public frm_AddTourDX()
		{
			InitializeComponent();
			this.button1.Click += new EventHandler(this.button1_Click);
			this.CenterToScreen();
			this.tourTypeBLL = new TourTypeBLL();
			this.khuyenMaiBLL = new KhuyenMaiBLL();
			this.Text = "Thêm tour";
			this.btn_luu.Click += new EventHandler(this.btn_them_Click);
			loadCBX();
		}
		public frm_AddTourDX(long matour)
		{
			InitializeComponent();
			this.CenterToScreen();
			this.button1.Click += new EventHandler(this.button1_Click);
			this.tourTypeBLL = new TourTypeBLL();
			this.khuyenMaiBLL = new KhuyenMaiBLL();
			this.btn_sua.Click += new EventHandler(this.btn_sua_Click);
			this.Text = "Sửa tour";
			loadCBX();
			loadSuaTour(matour);
		}



		private void btn_dong_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Bạn có muốn đóng hay không?",
				"Thông báo",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question
			);

			if (result == DialogResult.OK)
			{
				this.Close();
			}
		}
		private void loadCBX()
		{
			loadComboboxLoaiTour();
			loadComboboxMaKM();
		}
		private void loadComboboxLoaiTour()
		{
			List<loaitour> danhSachLoai = tourTypeBLL.layDanhSachLoaiTour();
			cbx_maloaitour.DataSource = danhSachLoai;
			cbx_maloaitour.DisplayMember = "tenloai";
			cbx_maloaitour.ValueMember = "maloaitour";
		}
		private void loadComboboxMaKM()
		{

			List<khuyenmai> danhSachKM = khuyenMaiBLL.layDanhSachKhuyenMai();

			danhSachKM.Insert(0, new khuyenmai
			{
				makhuyenmai = 0,
				phantramgiam = 0.0,
			});
			cbx_makhuyenmai.DataSource = danhSachKM;
			cbx_makhuyenmai.DisplayMember = "phantramgiam";
			cbx_makhuyenmai.ValueMember = "makhuyenmai";
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog1.FileName;
				txt_hinhdaidien.Text = filePath;

				txt_hinhdaidien.Text = Path.GetFileName(filePath);
				pictureBox1.Image = Image.FromFile(filePath);
			}
		}

		public string GenerateSlug(string text)
		{
			string slug = text.ToLower();
			slug = RemoveDiacritics(slug);
			slug = System.Text.RegularExpressions.Regex.Replace(slug, @"\s+", "-");
			slug = System.Text.RegularExpressions.Regex.Replace(slug, @"[^a-z0-9-]", "");
			slug = slug.Trim('-');
			return slug;
		}
		private static string RemoveDiacritics(string text)
		{
			var normalizedText = text.Normalize(NormalizationForm.FormD);
			var stringBuilder = new StringBuilder();

			foreach (var c in normalizedText)
			{
				var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
				if (unicodeCategory != UnicodeCategory.NonSpacingMark)
				{
					stringBuilder.Append(c);
				}
			}

			return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
		}
		private void btn_them_Click(object sender, EventArgs e)
		{
			if (txt_tentour.Text == "" || txt_noikhoihanh.Text == "" || txt_thoigiandi.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string filePath = openFileDialog1.FileName;

			if (!File.Exists(filePath))
			{
				MessageBox.Show("File hình ảnh không tồn tại");
				return;
			}

			string projectPath = Application.StartupPath;
			string resourcesPath = Path.Combine(projectPath, @"D:\WorkSpace\HocKi_7\PTPMTM\FormTourTravel\FormTourTravel\Resources");
			string webTourPath = Path.Combine(projectPath, @"C:\xampp\htdocs\Smart-Software-Website\public\frontend\images\tour");
			if (!Directory.Exists(resourcesPath))
			{
				Directory.CreateDirectory(resourcesPath);
				Directory.CreateDirectory(webTourPath);
			}

			string fileName = Path.GetFileName(filePath);
			string fileNameTour = Path.GetFileName(filePath);
			string destinationPath = Path.Combine(resourcesPath, fileName);
			string destinationPathTour = Path.Combine(webTourPath, fileNameTour);

			try
			{
				File.Copy(filePath, destinationPath, true);
				File.Copy(filePath, destinationPathTour, true);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi lưu hình ảnh: " + ex.Message);
				return;
			}
			tour tour = new tour();
			tour.tentour = txt_tentour.Text;
			tour.tinhtrang = 1;
			tour.slug = GenerateSlug(txt_tentour.Text);
			tour.motatour = txt_motatour.Text;
			tour.hinhdaidien = @"frontend/images/tour/" + fileName;
			tour.noikhoihanh = txt_noikhoihanh.Text;
			tour.thoigiandi = txt_thoigiandi.Text;
			tour.giatour = 0;
			tour.maloaitour = long.Parse(cbx_maloaitour.SelectedValue.ToString());

			tour.makhuyenmai = long.Parse(cbx_makhuyenmai.SelectedValue.ToString());
			if (tour.makhuyenmai == 0)
			{
				tour.makhuyenmai = null;
			}
			tour.created_at = DateTime.Now.Date;
			TourBLL tourBLL = new TourBLL();
			bool result = tourBLL.ThemTour(tour);
			if (result)
			{
				MessageBox.Show("Thêm tour thành công");
				this.Close();
			}
			else
			{
				MessageBox.Show("Thêm tour thất bại");
			}
		}

		private void txt_thoigiandi_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txt_giatour_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void loadSuaTour(long matour)
		{
			TourBLL tourBLL = new TourBLL();
			tour tour = tourBLL.LayTourTheoMa(matour);
			txt_matour.Text = matour.ToString();
			txt_tentour.Text = tour.tentour;
			txt_motatour.Text = tour.motatour;
			txt_noikhoihanh.Text = tour.noikhoihanh;
			openFileDialog1.FileName = tour.hinhdaidien;
			txt_thoigiandi.Text = tour.thoigiandi;
			txt_hinhdaidien.Text = tour.hinhdaidien;
			cbx_maloaitour.SelectedValue = tour.maloaitour;
			if (tour.makhuyenmai == null)
			{
				cbx_makhuyenmai.SelectedValue = 0;
			}
			else
			{
				cbx_makhuyenmai.SelectedValue = tour.makhuyenmai;
			}

		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			if (txt_tentour.Text == "" || txt_noikhoihanh.Text == "" || txt_thoigiandi.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			tour tour = new tour();
			tour.matour = long.Parse(txt_matour.Text);
			tour.tentour = txt_tentour.Text;
			tour.tinhtrang = 1;
			tour.slug = GenerateSlug(txt_tentour.Text);
			tour.motatour = txt_motatour.Text;
			tour.noikhoihanh = txt_noikhoihanh.Text;
			tour.thoigiandi = txt_thoigiandi.Text;
			tour.maloaitour = long.Parse(cbx_maloaitour.SelectedValue.ToString());
			tour.makhuyenmai = long.Parse(cbx_makhuyenmai.SelectedValue.ToString());

			if (!string.IsNullOrEmpty(openFileDialog1.FileName) && openFileDialog1.FileName != txt_hinhdaidien.Text) 
			{
				string imageFileName = Path.GetFileName(openFileDialog1.FileName); 
				string targetDirectory = @"D:\WorkSpace\HocKi_7\PTPMTM\FormTourTravel\FormTourTravel\Resources";
				string webTourDirectory = @"C:\xampp\htdocs\Smart-Software-Website\public\frontend\images\tour"; 

				string resourceFilePath = Path.Combine(targetDirectory, imageFileName);
				string webFilePath = Path.Combine(webTourDirectory, imageFileName);

				if (!Directory.Exists(targetDirectory))
				{
					Directory.CreateDirectory(targetDirectory);
				}
				if (!Directory.Exists(webTourDirectory))
				{
					Directory.CreateDirectory(webTourDirectory);
				}

				try
				{
					File.Copy(openFileDialog1.FileName, resourceFilePath, true); 
					File.Copy(openFileDialog1.FileName, webFilePath, true); 

					tour.hinhdaidien = $"frontend/images/tour/{imageFileName}";
				}
				catch (IOException ex)
				{
					MessageBox.Show($"Không thể sao chép file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else
			{
				tour.hinhdaidien = txt_hinhdaidien.Text;
			}

			TourBLL tourBLL = new TourBLL();
			bool result = tourBLL.SuaTour(tour);
			if (result)
			{
				MessageBox.Show("Sửa tour thành công");
				this.Close();
			}
			else
			{
				MessageBox.Show("Sửa tour thất bại");
			}
		}

		private void btn_luu_Click(object sender, EventArgs e)
		{

		}
	}
}