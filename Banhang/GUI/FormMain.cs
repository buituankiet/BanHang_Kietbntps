using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace Banhang.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public void Login()
        {
            quảnLýThôngTinToolStripMenuItem.Enabled = true;
            bánHàngToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
            thốngKêToolStripMenuItem.Enabled = true;
            
        }
        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham frm = new FormSanPham();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachhang frm = new FormKhachhang();
            frm.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon();
            hd.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MyLogin = new Form1.SetMenu(Login);
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát???","Thông cáo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                quảnLýThôngTinToolStripMenuItem.Enabled = false;
                bánHàngToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
                đăngXuấtToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DánhachhoaDon hd = new DánhachhoaDon();
            hd.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
