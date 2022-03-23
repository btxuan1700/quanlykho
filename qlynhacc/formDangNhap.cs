using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlynhacc.BLL;
using qlynhacc.DTO;


namespace qlynhacc
{

    public partial class formDangNhap : Form

       
    {

        
        public formDangNhap()
        {
            InitializeComponent();
        }
        dangnhapDTO dangNhapDTO = new dangnhapDTO();
        dangnhapBLL dangNhapBLL = new dangnhapBLL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttondn_Click(object sender, EventArgs e)
        {
            dangNhapDTO.Tk = txttk.Text.ToString();
            dangNhapDTO.Makhau = txtmk.Text.ToString();

            if(dangNhapBLL.dangnhap(dangNhapDTO)== true)
            {
                MessageBox.Show("dang nhap thanh cong");
                formHome home = new formHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("tai khoan hoac mat khau sai");
            }

        }
        
    }
}
