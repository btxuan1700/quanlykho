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
    public partial class formQlloaisp : Form
    {
        public formQlloaisp()
        {
            InitializeComponent();
            Hienthi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        loaispBLL bll = new loaispBLL();
        loaispDTO dto = new loaispDTO();

       public void Hienthi()
        {
            bll.HienThi(dgv); 
        }


        private void buttonthem_Click(object sender, EventArgs e)
        {
            if (txtmaloaisp.Text.Trim() != "")
            {
                //gan dl vao dto
                dto.Malsp = txtmaloaisp.Text;
                dto.Tenloaisp = txttenloaisp.Text;

                //goi bll thuc hien
                bll.Them(dto);
                //hienthi len datagrid
                bll.HienThi(dgv);
            }
        }
        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (txtmaloaisp.Text.Trim() != "")
            {
                //gan dl vao dto
                dto.Malsp = txtmaloaisp.Text;
                dto.Tenloaisp = txttenloaisp.Text;


                //ghi dl thuc hien
                bll.Sua(dto);
                //hienthi len datagrid
                bll.HienThi(dgv);
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmaloaisp.Text.Trim() != "")
            {
                //gan dl vao dto
                dto.Malsp = txtmaloaisp.Text;

                //ghi dl thuc hien
                bll.Xoa(dto);
                //hienthi len datagrid
                bll.HienThi(dgv);
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            txtmaloaisp.Text = dgv.Rows[r].Cells[0].Value.ToString();
            txttenloaisp.Text = dgv.Rows[r].Cells[1].Value.ToString();
            
        }


    }
}
