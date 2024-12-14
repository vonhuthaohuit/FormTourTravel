using BLL;
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
    public partial class frm_NhomQuyen : Form
    {
        private RoleBLL roleBLL= new RoleBLL();
        public frm_NhomQuyen()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgv_nhomquyen.DataSource = roleBLL.LayNhomQuyen();
            dgv_quyen.DataSource = roleBLL.layQuyen();
        }

        private void frm_NhomQuyen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_nhomquyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_nhomquyen.Rows[e.RowIndex];
                txt_manhomquyen.Text = row.Cells[0].Value.ToString();
                txt_tennhomquyen.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dgv_quyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_quyen.Rows[e.RowIndex];
                txt_maquyen.Text = row.Cells[0].Value.ToString();
                txt_tenquyen.Text = row.Cells[1].Value.ToString();
                txt_mota.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btn_themnhomquyen_Click(object sender, EventArgs e)
        {
            string tennhomquyen = txt_tennhomquyen.Text;

            nhomquyen nhomquyen = new nhomquyen()
            {
                tennhomquyen = tennhomquyen
            };

            if (roleBLL.ThemNhomQuyen(nhomquyen))
            {
                MessageBox.Show("Thêm nhóm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm nhóm quyền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoanhomquyen_Click(object sender, EventArgs e)
        {
            int manhomquyen = Convert.ToInt32(txt_manhomquyen.Text);

            if (roleBLL.XoaNhomQuyen(manhomquyen))
            {
                MessageBox.Show("Xóa nhóm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa nhóm quyền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_suanhomquyen_Click(object sender, EventArgs e)
        {
            int manhomquyen = Convert.ToInt32(txt_manhomquyen.Text);
            string tennhomquyen = txt_tennhomquyen.Text;

            nhomquyen nhomquyen = new nhomquyen()
            {
                manhomquyen = manhomquyen,
                tennhomquyen = tennhomquyen
            };

            if (roleBLL.SuaNhomQuyen(nhomquyen))
            {
                MessageBox.Show("Sửa nhóm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa nhóm quyền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_themquyen_Click(object sender, EventArgs e)
        {
            string tenquyen = txt_tenquyen.Text;
            string mota = txt_mota.Text;

            quyen quyen = new quyen()
            {
                tenquyen = tenquyen,
                mota = mota
            };

            if (roleBLL.ThemQuyen(quyen))
            {
                MessageBox.Show("Thêm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm quyền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoaquyen_Click(object sender, EventArgs e)
        {
            int maquyen = Convert.ToInt32(txt_maquyen.Text);

            if (roleBLL.XoaQuyen(maquyen))
            {
                MessageBox.Show("Xóa quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa quyền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_suaquyen_Click(object sender, EventArgs e)
        {
            int maquyen = Convert.ToInt32(txt_maquyen.Text);
            string tenquyen = txt_tenquyen.Text;
            string mota = txt_mota.Text;

            quyen quyen = new quyen()
            {
                maquyen = maquyen,
                tenquyen = tenquyen,
                mota = mota
            };

            if (roleBLL.SuaQuyen(quyen))
            {
                MessageBox.Show("Sửa quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa quyền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
