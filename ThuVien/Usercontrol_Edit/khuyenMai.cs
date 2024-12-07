using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.Usercontrol_Edit
{
    public partial class khuyenMai : UserControl
    {
        public event EventHandler<string[]> ThemClicked;
        public event EventHandler<string[]> SuaClicked;
        public event EventHandler<string[]> XoaClicked;
        public khuyenMai()
        {
            InitializeComponent();
            btn_them.Click += Btn_them_Click;
            btn_sua.Click += Btn_sua_Click;
            btn_xoa.Click += Btn_xoa_Click;
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            TextBox txt_makhuyenmai = this.Controls["txt_makhuyenmai"] as TextBox;
            if (txt_makhuyenmai != null)
            {
                string makhuyenmai = txt_makhuyenmai.Text;
                XoaClicked?.Invoke(this, new string[] { makhuyenmai });
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            TextBox txt_makhuyenmai = this.Controls["txt_makhuyenmai"] as TextBox;
            DateTimePicker ngaybatdau = this.Controls["ngaybatdau"] as DateTimePicker;
            DateTimePicker ngayketthuc = this.Controls["ngayketthuc"] as DateTimePicker;
            TextBox txt_phantramgiam = this.Controls["txt_phantramgiam"] as TextBox;

            if (txt_makhuyenmai != null && ngaybatdau != null && ngayketthuc != null && txt_phantramgiam != null)
            {
                string makhuyenmai = txt_makhuyenmai.Text;
                string thoigianbatdau = ngaybatdau.Text;
                string thoigianketthuc = ngayketthuc.Text;
                string phantramgiam = txt_phantramgiam.Text;
                SuaClicked?.Invoke(this, new string[] { makhuyenmai, thoigianbatdau, thoigianketthuc, phantramgiam });
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            DateTimePicker ngaybatdau = this.Controls["ngaybatdau"] as DateTimePicker;
            DateTimePicker ngayketthuc = this.Controls["ngayketthuc"] as DateTimePicker;
            TextBox txt_phantramgiam = this.Controls["txt_phantramgiam"] as TextBox;

            if (ngaybatdau != null && ngayketthuc != null && txt_phantramgiam != null)
            {
                string thoigianbatdau = ngaybatdau.Text;
                string thoigianketthuc = ngayketthuc.Text;
                string phantramgiam = txt_phantramgiam.Text;

                ThemClicked?.Invoke(this, new string[] { thoigianbatdau, thoigianketthuc, phantramgiam });
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public object DataSourceDatagirdView
        {
            get => dgv_KhuyenMai.DataSource;
            set
            {
                dgv_KhuyenMai.DataSource = value;
                HideColumns();
            }
        }

        private void HideColumns()
        {
            if (dgv_KhuyenMai.Columns["created_at"] != null)
            {
                dgv_KhuyenMai.Columns["created_at"].Visible = false;
            }
            if (dgv_KhuyenMai.Columns["updated_at"] != null)
            {
                dgv_KhuyenMai.Columns["updated_at"].Visible = false;
            }
            if(dgv_KhuyenMai.Columns["tours"] != null)
            {
                dgv_KhuyenMai.Columns["tours"].Visible = false;
            }
        }

        private void dgv_KhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhuyenMai.Rows[e.RowIndex]; 
                txt_makhuyenmai.Text = row.Cells["makhuyenmai"].Value.ToString();
                ngaybatdau.Text = row.Cells["thoigianbatdau"].Value.ToString();
                ngayketthuc.Text = row.Cells["thoigianketthuc"].Value.ToString();
                txt_phantramgiam.Text = row.Cells["phantramgiam"].Value.ToString();
            }
        }


    }
}
