using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace ThuVien.Usercontrol_Edit
{
    public partial class CapQuyenTaiKhoan : UserControl
    {
        public event EventHandler<string[]> ThemClicked;
        public event EventHandler<string[]> XoaClicked;
        public event EventHandler<string[]> SuaClicked;
        public event EventHandler LuuClicked;
        public event EventHandler LamMoiClicked;
        public CapQuyenTaiKhoan()
        {
            InitializeComponent();
            //chucNangNenCo1.ThemClicked += (s, e) => ThemClicked?.Invoke(this, e);
            //chucNangNenCo1.XoaClicked += (s, e) => XoaClicked?.Invoke(this, e);
            //chucNangNenCo1.SuaClicked += (s, e) => SuaClicked?.Invoke(this, e);
            //chucNangNenCo1.LuuClicked += (s, e) => LuuClicked?.Invoke(this, e);
            //chucNangNenCo1.LamMoiClicked += (s, e) => LamMoiClicked?.Invoke(this, e);
            btn_them.Click += Btn_them_Click;
            btn_xoa.Click += Btn_xoa_Click;
            btn_update.Click += Btn_update_Click;
            loadCboTrangThai();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            ComboBox cbo_mataikhoan = groupBox1.Controls["cbo_TaiKhoan"] as ComboBox;
            TextBox txt_tendangnhap = groupBox1.Controls["txt_tendangnhap"] as TextBox;
            TextBox txt_matkhau = groupBox1.Controls["txt_matkhau"] as TextBox;
            TextBox txt_email = groupBox1.Controls["txt_email"] as TextBox;
            ComboBox cbo_trangthai = groupBox1.Controls["cbo_trangthai"] as ComboBox;
            ComboBox cbo_nhomquyen = groupBox1.Controls["cbo_nhomquyen"] as ComboBox;

            if (cbo_mataikhoan != null && txt_tendangnhap != null && txt_matkhau != null && cbo_trangthai != null && cbo_nhomquyen != null && txt_email != null)
            {
                string mataikhoan = cbo_mataikhoan.SelectedValue.ToString();
                string tendangnhap = txt_tendangnhap.Text;
                string email = txt_email.Text;
                string matkhau = txt_matkhau.Text;
                string trangthai = cbo_trangthai.SelectedValue.ToString();
                string manhomquyen = cbo_nhomquyen.SelectedValue.ToString();
                SuaClicked?.Invoke(this, new string[] { mataikhoan, tendangnhap, email, matkhau, trangthai, manhomquyen });
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            ComboBox cbo_mataikhoan = groupBox1.Controls["cbo_TaiKhoan"] as ComboBox;
            if (cbo_mataikhoan != null)
            {
                string mataikhoan = cbo_mataikhoan.SelectedValue.ToString();
                XoaClicked?.Invoke(this, new string[] { mataikhoan });
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            TextBox txt_tendangnhap = groupBox1.Controls["txt_tendangnhap"] as TextBox;
            TextBox txt_matkhau = groupBox1.Controls["txt_matkhau"] as TextBox;
            TextBox txt_email = groupBox1.Controls["txt_email"] as TextBox;
            ComboBox cbo_trangthai = groupBox1.Controls["cbo_trangthai"] as ComboBox;
            ComboBox cbo_nhomquyen = groupBox1.Controls["cbo_nhomquyen"] as ComboBox;
            if (txt_tendangnhap != null && txt_matkhau != null && cbo_TaiKhoan != null && cbo_nhomquyen != null && cbo_trangthai != null && txt_email != null)
            {
                string tendangnhap = txt_tendangnhap.Text;
                string email = txt_email.Text;
                string matkhau = txt_matkhau.Text;
                string trangthai = cbo_trangthai.SelectedValue.ToString();
                string manhomquyen = cbo_nhomquyen.SelectedValue.ToString();
                ThemClicked?.Invoke(this, new string[] { tendangnhap, email, matkhau, trangthai, manhomquyen });
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public object DataSourceDatagirdView
        {
            get => dgv_TaiKhoan.DataSource;
            set
            {
                dgv_TaiKhoan.DataSource = value;
                HideColumns();
            }
        }
        public object CboTaiKhoan_DataSource
        {
            get => cbo_TaiKhoan.DataSource;
            set
            {
                cbo_TaiKhoan.DataSource = value;

                cbo_TaiKhoan.DisplayMember = "tentaikhoan";
                cbo_TaiKhoan.ValueMember = "mataikhoan";
            }
        }
        public object CboNhomQuyen_DataSource
        {
            get => cbo_nhomquyen.DataSource;
            set
            {
                cbo_nhomquyen.DataSource = value;

                cbo_nhomquyen.DisplayMember = "tennhomquyen";
                cbo_nhomquyen.ValueMember = "manhomquyen";
            }
        }

        public void loadCboTrangThai()
        {
            var trangThaiList = new List<string>
            {
                "Hoạt động",
                "Khóa"
            };

            cbo_trangthai.DataSource = trangThaiList;
        }


        private void HideColumns()
        {
            if (dgv_TaiKhoan.Columns["created_at"] != null)
            {
                dgv_TaiKhoan.Columns["created_at"].Visible = false;
            }
            if (dgv_TaiKhoan.Columns["updated_at"] != null)
            {
                dgv_TaiKhoan.Columns["updated_at"].Visible = false;
            }
            if (dgv_TaiKhoan.Columns["nhanviens"] != null)
            {
                dgv_TaiKhoan.Columns["nhanviens"].Visible = false;
            }
            if (dgv_TaiKhoan.Columns["khachhangs"] != null)
            {
                dgv_TaiKhoan.Columns["khachhangs"].Visible = false;
            }
            if (dgv_TaiKhoan.Columns["nhomquyen"] != null)
            {
                dgv_TaiKhoan.Columns["nhomquyen"].Visible = false;
            }
            //if (dgv_TaiKhoan.Columns["remember_token"] != null)
            //{
            //    dgv_TaiKhoan.Columns["remember_token"].Visible = false;
            //}
            //if (dgv_TaiKhoan.Columns["google_id"] != null)
            //{
            //    dgv_TaiKhoan.Columns["google_id"].Visible = false;
            //}
            //if (dgv_TaiKhoan.Columns["email_verified_at"] != null)
            //{
            //    dgv_TaiKhoan.Columns["email_verified_at"].Visible = false;
            //}
        }

        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_TaiKhoan.Rows[e.RowIndex];
                cbo_TaiKhoan.Text = row.Cells["tentaikhoan"].Value.ToString();
                txt_tendangnhap.Text = row.Cells["tentaikhoan"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
                txt_matkhau.Text = row.Cells["matkhau"].Value.ToString();
                cbo_trangthai.Text = row.Cells["trangthai"].Value.ToString();
                string manhomquyen = row.Cells["manhomquyen"].Value.ToString();

                var selectedItem = cbo_nhomquyen.Items.Cast<dynamic>()
                            .FirstOrDefault(item => item.manhomquyen.ToString() == manhomquyen);

                if (selectedItem != null)
                {
                    cbo_nhomquyen.SelectedItem = selectedItem;
                }
            }
        }
    }
}
