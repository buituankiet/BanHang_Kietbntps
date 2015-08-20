using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Banhang.Entities;
using Banhang.Business;

namespace Banhang.GUI
{
    public partial class FormLoaiSP : Form
    {
        public FormLoaiSP()
        {
            InitializeComponent();
        }

        private void FormLoaiSP_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = BLOAISANPHAM.SelectAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ELOAISANPHAM el = new ELOAISANPHAM();
            el.MAL = txtma.Text.Trim();
            el.TENL = txtten.Text.Trim();
            el.MOTA = txtmota.Text.Trim();
            BLOAISANPHAM.Insert(el);
            FormLoaiSP_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            ELOAISANPHAM el = new ELOAISANPHAM();
            el.MAL = txtma.Text.Trim();
            el.TENL = txtten.Text.Trim();
            el.MOTA = txtmota.Text.Trim();
            BLOAISANPHAM.Update(el);
            FormLoaiSP_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muỗn xóa thông tin này???","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                BLOAISANPHAM.Delete(txtma.Text.Trim());
                FormLoaiSP_Load(sender, e);
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
            txtma.Text = row.Cells[0].Value.ToString();
            txtten.Text = row.Cells[1].Value.ToString();
            txtmota.Text = row.Cells[2].Value.ToString();
        }
    }
}
