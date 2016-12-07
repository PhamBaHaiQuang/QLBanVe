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
    public partial class Kiem_Tra_Dat_Ve : Form
    {
        public Kiem_Tra_Dat_Ve()
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

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Thông tin đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = MessageBox.Show("Bạn có muốn hủy?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.OK)
                {
                    txtDienThoai.Text = "";
                }
            } 
        }

        private void Kiem_Tra_Dat_Ve_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {
            if (txtDienThoai.Text != "")
            {
                Lay_Ve_Online lvo = new Lay_Ve_Online();
                this.Visible = false;
                lvo.Sender(txtDienThoai.Text);
                lvo.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin chưa được nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
