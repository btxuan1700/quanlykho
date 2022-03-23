using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlynhacc
{
    
    public partial class formHome : Form
    {
        bool isThoat = true;
        public formHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonqlncc_Click(object sender, EventArgs e)
        {
            formQlncc qlncc = new formQlncc();
            qlncc.Show();
            this.Hide();
        }

        private void buttondangxuat_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            formDangNhap f = new formDangNhap();
            f.Show();

        }
    }
}
