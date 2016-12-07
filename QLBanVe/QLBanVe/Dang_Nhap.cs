﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanVe
{
    public partial class Dang_Nhap : Form
    {
        public Dang_Nhap()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Thông tin đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = MessageBox.Show("Bạn có muốn hủy?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.OK)
                {
                    txtMaNV.Text = "";
                    txtMatKhau.Text = "";
                }
            } 
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtMatKhau.Text != "")
            {
                Chooses ch = new Chooses();
                this.Visible = false;
                ch.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin chưa được nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Dang_Nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

    }
}
