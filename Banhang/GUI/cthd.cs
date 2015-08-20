using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Banhang.Business;
namespace Banhang.GUI
{
    public partial class cthd : Form
    {
        public cthd()
        {
            InitializeComponent();
        }
        string shd = "";
        public cthd(string _shd)
        {
            this.shd = _shd;
            InitializeComponent();
        }
        private void cthd_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = BCHITIETHOADON.SelectAll(shd);
            txttongtien.Text = tongtien() + "";
        }
        private double tongtien()
        {
            double tongtien = 0;
            for (int i = 0; i < dgvData.RowCount - 1; i++)
            {
                tongtien += double.Parse(dgvData.Rows[i].Cells[6].Value.ToString());
            }
            return tongtien;
        }
    }
}
