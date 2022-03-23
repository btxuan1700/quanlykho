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
    public partial class formsanpham : Form
    {
        public formsanpham()
        {
            InitializeComponent();
            hienthi();
        }
        loaispBLL lsp = new loaispBLL();
        sanphamBLL sp = new sanphamBLL();
        sanphamDTO spdto = new sanphamDTO();
        qlnhaccBLL ncc = new qlnhaccBLL();

        

        private void button1_Click(object sender, EventArgs e)
        {
            spdto.Malsp1 = txtmalsp.Text.ToString();
            spdto.Manccư1 = txtmancc.Text.ToString();
            spdto.Masp1 = txtmasp.Text.ToString();
            spdto.Tensp = txttensp.Text.ToString();
            spdto.Soluong1 = txtsoluong.Text.ToString();
            spdto.Gia1 = txtgia.Text.ToString();
            if (ncc.getmancc(spdto)==true&&lsp.getmalsp(spdto)==true&&sp.getmasp(spdto)==false)
            {
                
                sp.them(spdto);
                MessageBox.Show("nhập thành công");
                hienthi();

            }
            else
            {
                MessageBox.Show("Lỗi mã");
            }    
        }
        public void hienthi()
        {
            sp.HienThi(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
