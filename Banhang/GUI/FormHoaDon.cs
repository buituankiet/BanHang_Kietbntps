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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }


        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = BCHITIETHOADON.SelectAll(txtsdt.Text.Trim());
            cbbsp.DataSource = BSANPHAM.SelectAll();
            cbbsp.DisplayMember = "Tên sản phẩm";
            cbbsp.ValueMember = "Mã sản phẩm";
            if (cbbsp.Items.Count>0)
            {
                txtmasp.Text = cbbsp.SelectedValue.ToString();
            }
        }
        bool isHD = false;
        private void button1_Click(object sender, EventArgs e)
        {
            EKHACHHANG ek = new EKHACHHANG();
            ek.MAKH = txtsdt.Text.Trim();
            ek.TENK = txttenk.Text.Trim();
            ek.GIOITINH = rdNam.Checked ? "Nam" : "Nữ";
            ek.SDT = txtsdt.Text.Trim();
            ek.DIACHI = txtdc.Text.Trim();
            DataTable dt = BKHACHHANG.SelectAll(txtsdt.Text.Trim());
            if (dt == null || dt.Rows.Count == 0)
            {
                BKHACHHANG.Insert(ek);
            }
            else { BKHACHHANG.Update(ek); }
            //hoa don
            EHOADON ehd = new EHOADON();
            ehd.SOHOADON = txtshd.Text.Trim();
            ehd.NGAYHOADON = dtngay.Value.Day.ToString() + "/" + dtngay.Value.Month.ToString() + "/" + dtngay.Value.Year.ToString();
            ehd.MAKH = txtsdt.Text.Trim();
            ehd.NHANVIEN = txtnv.Text.Trim();
            ehd.GHICHU = txtghichu.Text.Trim();
            if (!isHD)
            {
                BHOADON.Insert(ehd);
                isHD = true;
            }
            else { BHOADON.Update(ehd); }
            button1.Text = "Sửa hóa đơn";
            grbcthd.Enabled = true;

        }

        private void cbbsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbsp.Items.Count != 0 && cbbsp.SelectedIndex != 0)
            {
                txtmasp.Text = cbbsp.SelectedValue.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ECHITIETHOADON ect = new ECHITIETHOADON();
            ect.SOHOADON = txtshd.Text.Trim();
            ect.MASP = txtmasp.Text.Trim();
            int sl = 0;
            int.TryParse(txtsl.Text.Trim(), out sl);
            ect.SOLUONG = sl;
            float ck = 0;
            float.TryParse(txtck.Text.Trim(), out ck);
            ect.CHIETKHAU = ck;
            BCHITIETHOADON.Insert(ect);
            dgvData.DataSource = BCHITIETHOADON.SelectAll(txtshd.Text.Trim());
            txttongtien.Text = tongtien() + "";
        }
        private double tongtien()
        {
            double tongtien = 0;
            for (int i = 0; i < dgvData.RowCount-1; i++)
            {
                tongtien += double.Parse(dgvData.Rows[i].Cells[6].Value.ToString());
            }
            return tongtien;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ECHITIETHOADON ect = new ECHITIETHOADON();
            ect.SOHOADON = txtshd.Text.Trim();
            ect.MASP = txtmasp.Text.Trim();
            int sl = 0;
            int.TryParse(txtsl.Text.Trim(), out sl);
            ect.SOLUONG = sl;
            float ck = 0;
            float.TryParse(txtck.Text.Trim(), out ck);
            ect.CHIETKHAU = ck;
            BCHITIETHOADON.Update(ect);
            txttongtien.Text = tongtien() + "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muỗn xóa thông tin này???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BCHITIETHOADON.Delete(txtshd.Text.Trim(),txtmasp.Text.Trim());
                dgvData.DataSource=BCHITIETHOADON.SelectAll(txtshd.Text.Trim());
            }
        }

        private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i=e.RowIndex;
            if (i==dgvData.Rows.Count-1|| dgvData.Rows.Count==1)
            {
                return;
            }
            DataGridViewRow row = dgvData.Rows[i];
            txtmasp.Text = row.Cells[1].Value.ToString();
            cbbsp.SelectedValue = row.Cells[1].Value.ToString();
            txtsl.Text = row.Cells[3].Value.ToString();
            txtdg.Text = row.Cells[4].Value.ToString();
            txtck.Text = row.Cells[5].Value.ToString();
        }
        string strck = "";
        private void txtck_KeyDown(object sender, KeyEventArgs e)
        {
            string ck = txtck.Text.Trim();
            if (ck.Length <= 2)
            {
                strck = ck;
            }
            else
                txtck.Text = strck;
        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
