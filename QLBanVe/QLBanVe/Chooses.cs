using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanVe
{
    public partial class Chooses : Form
    {
        public Chooses()
        {
            InitializeComponent();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            Dang_Nhap dn = new Dang_Nhap();
            this.Visible = false;
            dn.ShowDialog();
            this.Close();
        }

        private void btBanVe_Click(object sender, EventArgs e)
        {
            Quan_Ly_Ban_Ve qlbv = new Quan_Ly_Ban_Ve();
            this.Visible = false;
            qlbv.ShowDialog();
            this.Close();
        }

        private void btVeOnline_Click(object sender, EventArgs e)
        {
            Kiem_Tra_Dat_Ve ktdv = new Kiem_Tra_Dat_Ve();
            this.Visible = false;
            ktdv.ShowDialog();
            this.Close();
        }

        private void Chooses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
