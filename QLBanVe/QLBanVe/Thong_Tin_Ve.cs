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
    public partial class Thong_Tin_Ve : Form
    {
        public Thong_Tin_Ve()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Chooses ch = new Chooses();
            this.Visible = false;
            ch.ShowDialog();
            this.Close();
        }

    }
}
