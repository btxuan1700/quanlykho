using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlynhacc.BLL;
using qlynhacc.DTO;
using System.Xml;
using System.Windows.Forms;

namespace qlynhacc.BLL
{
    public class sanphamBLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        string filename = @"C:\Users\Admin\source\repos\qlynhacc\qlynhacc\sanpham.xml";

       public sanphamBLL()
        {
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void them(sanphamDTO sp)
        {
            XmlNode sanpham = doc.CreateElement("sanpham");

            XmlElement malsp = doc.CreateElement("malsp");
            malsp.InnerText = sp.Malsp1;
            sanpham.AppendChild(malsp);

            XmlElement Masp = doc.CreateElement("masp");
            Masp.InnerText = sp.Masp1;
            sanpham.AppendChild(Masp);

            XmlElement Mancc = doc.CreateElement("Mancc");
            Mancc.InnerText = sp.Mancc1;
            sanpham.AppendChild(Mancc);

            XmlElement tensp = doc.CreateElement("tensp");
            tensp.InnerText = sp.Tensp;
            sanpham.AppendChild(tensp);

            XmlElement soluong = doc.CreateElement("soluong");
            soluong.InnerText = sp.Soluong1;
            sanpham.AppendChild(soluong);

            XmlElement gia = doc.CreateElement("gia");
            gia.InnerText = sp.Gia1;
            sanpham.AppendChild(gia);

            root.AppendChild(sanpham);
            doc.Save(filename);


            
        }
        public Boolean getmasp(sanphamDTO sp)
        {
            XmlNode loai = root.SelectSingleNode("sanpham[masp = '" + sp.Masp1+ "' ]");
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
        public void HienThi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 6;
            XmlNodeList ds = root.SelectNodes("sanpham");
            int sd = 0;//luu chi so dong
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("malsp").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("masp").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("Mancc").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("tensp").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("soluong").InnerText;
                dgv.Rows[sd].Cells[5].Value = item.SelectSingleNode("gia").InnerText;
                sd++;
            }
        }

    }
}
