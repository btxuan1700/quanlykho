using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using qlynhacc.DTO;

namespace qlynhacc.BLL
{
    public class loaispBLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;

        string fileName = @"C:\Users\Admin\source\repos\qlynhacc\qlynhacc\Loaisp.xml";
        private string malsp;
        private string tenloaisp;

        public loaispBLL()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(loaispDTO themLsp)
        {
            //tao nut nha cung cap
            XmlNode SP = doc.CreateElement("SP");

            //tao nut con cua nha cung cap la ma nha cung cap
            XmlElement malsp = doc.CreateElement("maloaisp");
            malsp.InnerText = themLsp.Malsp;//gan gia tri cho ma ncc
            SP.AppendChild(malsp);//them ma ncc vao ncc(nhan ma ncc)

            XmlElement tenloaisp = doc.CreateElement("tenloaisp");
            tenloaisp.InnerText = themLsp.Tenloaisp;
            SP.AppendChild(tenloaisp);

            //sau khi tao xong ncc,thi them ncc vap goc root
            root.AppendChild(SP);
            doc.Save(fileName);//luu dl

        }

        public Boolean getmalsp(sanphamDTO sp)
        {
            XmlNode loai = root.SelectSingleNode("SP[maloaisp = '" + sp.Malsp1 + "' ]");
            int cout = 0;
            if (loai != null)
            {
                cout++;

            }
            if (cout > 0)
            {
                return true;
            }
            return false;
        }
        public void Sua(loaispDTO suaLsp)
        {
            //lay vi tri can sua theo ma ncc cu

            XmlNode lspcu = root.SelectSingleNode("SP[malsp = '" + suaLsp.Malsp + "']");
            if (lspcu != null)
            {
                XmlNode suaMoi = doc.CreateElement("SP");

                XmlElement mancc = doc.CreateElement("maloaisp");
                mancc.InnerText = suaLsp.Malsp;//gan gia tri cho ma ncc
                suaMoi.AppendChild(mancc);//them ma ncc vao ncc(nhan ma ncc)

                XmlElement tenncc = doc.CreateElement("tenloaisp");
                tenncc.InnerText = suaLsp.Tenloaisp;
                suaMoi.AppendChild(tenncc);


                // thay the ncc cu(sua)
                root.ReplaceChild(suaMoi, lspcu);
                doc.Save(fileName);//luu dl

            }
        }
      
        public void Xoa(loaispDTO xoaLsp)
        {
            XmlNode lspCanXoa = root.SelectSingleNode("SP[maloaisp ='" + xoaLsp.Malsp + "']");
            
            if (lspCanXoa != null)
            {
                root.RemoveChild(lspCanXoa);

                doc.Save(fileName);
            }
        }

        public void HienThi(DataGridView dgv)
        {
           
            dgv.ColumnCount = 2;
            XmlNodeList ds = root.SelectNodes("SP");
            int sd = 0;//luu chi so dong
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("maloaisp").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("tenloaisp").InnerText;

                sd++;
            }
        }

    }
}
