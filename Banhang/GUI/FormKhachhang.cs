using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using Banhang.Business;
using Banhang.Entities;
using System.Windows.Forms;

namespace Banhang.GUI
{
    public partial class FormKhachhang : Form
    {
        public FormKhachhang()
        {
            InitializeComponent();
        }

        private void FormKhachhang_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = BKHACHHANG.SelectAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i < dgvData.Rows.Count-1; i++)
            {
                if (txtsdt.Text.Trim()==dgvData.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Khách hàng đã tồn tại, vui lồng nhấn nút sửa để cập nhật thông tin","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            EKHACHHANG ek = new EKHACHHANG();
            ek.MAKH = txtsdt.Text.Trim();
            ek.TENK = txttenk.Text.Trim();
            ek.GIOITINH = rdNam.Checked ? "Nam" : "Nữ";
            ek.SDT = txtsdt.Text.Trim();
            ek.DIACHI = txtdc.Text.Trim();
            BKHACHHANG.Insert(ek);
            FormKhachhang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EKHACHHANG ek = new EKHACHHANG();
            ek.MAKH = txtsdt.Text.Trim();
            ek.TENK = txttenk.Text.Trim();
            ek.GIOITINH = rdNam.Checked ? "Nam" : "Nữ";
            ek.SDT = txtsdt.Text.Trim();
            ek.DIACHI = txtdc.Text.Trim();
            BKHACHHANG.Update(ek);
            FormKhachhang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muỗn xóa thông tin này???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BKHACHHANG.Delete(txtsdt.Text.Trim());
                FormKhachhang_Load(sender, e);
            }
        }

        private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = e.RowIndex;
            if (i == dgvData.Rows.Count - 1 || dgvData.Rows.Count == 1)
            {
                return;
            }
            DataGridViewRow row = dgvData.Rows[i];
            txttenk.Text = row.Cells[1].Value.ToString();
            txtsdt.Text = row.Cells[3].Value.ToString();
            txtdc.Text = row.Cells[4].Value.ToString();
            string gt = row.Cells[2].Value.ToString();
            if (gt == "Nam")
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
            else
            {
                rdNu.Checked = true;
                rdNam.Checked = false;
            }
        }
    }
}
