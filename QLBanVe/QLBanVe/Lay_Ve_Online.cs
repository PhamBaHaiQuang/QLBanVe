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
    public partial class Lay_Ve_Online : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public Lay_Ve_Online()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }

        private void GetMessage(string Message)
        {
            lbDienThoai.Text = Message;
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            Chooses ch = new Chooses();
            this.Visible = false;
            ch.ShowDialog();
            this.Close();
        }

        private void Lay_Ve_Online_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btLayVe_Click(object sender, EventArgs e)
        {
            Thong_Tin_Ve ttv = new Thong_Tin_Ve();
            this.Visible = false;
            ttv.ShowDialog();
            this.Close();
        }
    }
}
