using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Banhang.Entities;
using System.Text;
using Banhang.Business;
using System.Windows.Forms;

namespace Banhang.GUI
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = BSANPHAM.SelectAll();
            cbbtenloai.DataSource = BLOAISANPHAM.SelectAll();
            cbbtenloai.DisplayMember = "Tên loại";
            cbbtenloai.ValueMember = "Mã loại";
           if(cbbtenloai.Items.Count>0) txtmal.Text = cbbtenloai.SelectedValue.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ESANPHAM esp = new ESANPHAM();
            esp.MASP = txtma.Text.Trim();
            esp.TENSP = txtten.Text.Trim();
            esp.MAL = txtmal.Text.Trim();
            esp.DONGIA = float.Parse(txtgia.Text.Trim());
            esp.MOTA = txtmota.Text.Trim();
            BSANPHAM.Insert(esp);
            FormSanPham_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ESANPHAM esp = new ESANPHAM();
            esp.MASP = txtma.Text.Trim();
            esp.TENSP = txtten.Text.Trim();
            esp.MAL = txtmal.Text.Trim();
            esp.DONGIA = float.Parse(txtgia.Text.Trim());
            esp.MOTA = txtmota.Text.Trim();
            BSANPHAM.Update(esp);
            FormSanPham_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muỗn xóa thông tin này???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BSANPHAM.Delete(txtma.Text.Trim());
                FormSanPham_Load(sender, e);
            }
        }

        private void cbbtenloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtenloai.Items.Count != 0 && cbbtenloai.SelectedIndex != 0)
            {
                txtmal.Text = cbbtenloai.SelectedValue.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLoaiSP frm = new FormLoaiSP();
            frm.ShowDialog();
            cbbtenloai.DataSource = BLOAISANPHAM.SelectAll();
            cbbtenloai.DisplayMember = "Tên loại";
            cbbtenloai.ValueMember = "Mã loại";
            if (cbbtenloai.Items.Count > 0) txtmal.Text = cbbtenloai.SelectedValue.ToString();
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
            cbbtenloai.SelectedValue = row.Cells[2].Value.ToString();
            txtmal.Text = row.Cells[2].Value.ToString();
            txtgia.Text = row.Cells[4].Value.ToString();
            txtmota.Text = row.Cells[5].Value.ToString();
        }
    }
}
