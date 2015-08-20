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
    public partial class DánhachhoaDon : Form
    {
        public DánhachhoaDon()
        {
            InitializeComponent();
        }

        private void DánhachhoaDon_Load(object sender, EventArgs e)
        {
            dgvdata.DataSource = BHOADON.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cthd ct = new cthd(this.shd);
            ct.ShowDialog();
        }
        string shd = "";
        private void dgvdata_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = e.RowIndex;
            if (i == dgvdata.Rows.Count - 1 || dgvdata.Rows.Count == 1)
            {
                return;
            }
            DataGridViewRow row = dgvdata.Rows[i];
            shd = row.Cells[0].Value.ToString();
            textBox1.Text = shd;
        }
    }
}
