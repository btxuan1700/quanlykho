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
    public partial class formQlncc : Form
    {
        bool isThoat = true;
        public formQlncc()
        {
            InitializeComponent();
        }
        qlnhaccBLL nccBLL = new qlnhaccBLL();
        nhaccDTO nccDTO = new nhaccDTO();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btnnhapfile_Click(object sender, EventArgs e)
        {
            nccBLL.HienThi(dgv);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text.Trim() != "")
            {
                //gan dl vao dto
                nccDTO.Mancc = txtmancc.Text;
                nccDTO.Tenncc = txttenncc.Text;
                nccDTO.Diachi = txtdiachi.Text;
                nccDTO.Sdt = txtsdt.Text;
                nccDTO.Email = txtemail.Text;

                //ghi dl thuc hien
                nccBLL.Sua(nccDTO);
                //hienthi len datagrid
                nccBLL.HienThi(dgv);
            }
        }

       

        private void btnthem_Click(object sender, EventArgs e)
        {

            if(txtmancc.Text.Trim() != "")
            {
                //gan dl vao dto
                nccDTO.Mancc = txtmancc.Text;
                nccDTO.Tenncc = txttenncc.Text;
                nccDTO.Diachi = txtdiachi.Text;
                nccDTO.Sdt = txtsdt.Text;
                nccDTO.Email = txtemail.Text;

                //goi bll thuc hien
                nccBLL.Them(nccDTO);
                //hienthi len datagrid
                nccBLL.HienThi(dgv);
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text.Trim() != "")
            {
                //gan dl vao dto
                nccDTO.Mancc = txtmancc.Text;
              
                //ghi dl thuc hien
                nccBLL.Xoa(nccDTO);
                //hienthi len datagrid
                nccBLL.HienThi(dgv);
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            formHome f = new formHome();
            f.Show();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            txtmancc.Text = dgv.Rows[r].Cells[0].Value.ToString();
            txttenncc.Text = dgv.Rows[r].Cells[1].Value.ToString();
            txtdiachi.Text = dgv.Rows[r].Cells[2].Value.ToString();
            txtsdt.Text = dgv.Rows[r].Cells[3].Value.ToString();
            txtemail.Text = dgv.Rows[r].Cells[4].Value.ToString();
        }
    }
}
