using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace Banhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void SetMenu();
        // khai báo 1 kiểu hàm delegate
        public SetMenu MyLogin;      
   
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text=="12345")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                if (MyLogin != null)
                {// tại đây gọi nó
                    MyLogin();
                    this.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            textBox2.Text = "";
        }
    }
}
