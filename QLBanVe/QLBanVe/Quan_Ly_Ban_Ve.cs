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
    public partial class Quan_Ly_Ban_Ve : Form
    {
        public Quan_Ly_Ban_Ve()
        {
            InitializeComponent();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            Chooses ch = new Chooses();
            this.Visible = false;
            ch.ShowDialog();
            this.Close();
        }

        private void Quan_Ly_Ban_Ve_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btGiaoDich_Click(object sender, EventArgs e)
        {
            Thong_Tin_Ve ttv = new Thong_Tin_Ve();
            this.Visible = false;
            ttv.ShowDialog();
            this.Close();
        }

    }
}
