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
    internal class qlnhaccBLL
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = @"C:\Users\Admin\source\repos\qlynhacc\qlynhacc\qlnhacc.xml";

        public qlnhaccBLL()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public void Them(nhaccDTO themNcc)
        {
            //tao nut nha cung cap
            XmlNode ncc = doc.CreateElement("ncc");
            //tao nut con cua nha cung cap la ma nha cung cap
            XmlElement mancc = doc.CreateElement("mancc");
            mancc.InnerText = themNcc.Mancc;//gan gia tri cho ma ncc
            ncc.AppendChild(mancc);//them ma ncc vao ncc(nhan ma ncc)

            XmlElement tenncc = doc.CreateElement("tenncc");
            tenncc.InnerText = themNcc.Tenncc;
            ncc.AppendChild(tenncc);

            XmlElement diachi = doc.CreateElement("diachi");
            diachi.InnerText = themNcc.Diachi;
            ncc.AppendChild(diachi);

            XmlElement sdt = doc.CreateElement("sdt");
            sdt.InnerText = themNcc.Sdt;
            ncc.AppendChild(sdt);

            XmlElement email = doc.CreateElement("email");
            email.InnerText = themNcc.Email;
            ncc.AppendChild(email);

            //sau khi tao xong ncc,thi them ncc vap goc root
            root.AppendChild(ncc);
            doc.Save(fileName);//luu dl

        }
        public void Sua(nhaccDTO suaNcc)
        {
            //lay vi tri can sua theo ma ncc cu

            XmlNode ncccu = root.SelectSingleNode("ncc[mancc = '" + suaNcc.Mancc + "']");
            if(ncccu != null)
            {
                XmlNode suaMoi = doc.CreateElement("ncc");

                XmlElement mancc = doc.CreateElement("mancc");
                mancc.InnerText = suaNcc.Mancc;//gan gia tri cho ma ncc
                suaMoi.AppendChild(mancc);//them ma ncc vao ncc(nhan ma ncc)

                XmlElement tenncc = doc.CreateElement("tenncc");
                tenncc.InnerText = suaNcc.Tenncc;
                suaMoi.AppendChild(tenncc);

                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = suaNcc.Diachi;
                suaMoi.AppendChild(diachi);

                XmlElement sdt = doc.CreateElement("sdt");
                sdt.InnerText = suaNcc.Sdt;
                suaMoi.AppendChild(sdt);

                XmlElement email = doc.CreateElement("email");
                email.InnerText = suaNcc.Email;
                suaMoi.AppendChild(email);

                // thay the ncc cu(sua)
                root.ReplaceChild(suaMoi,ncccu);
                doc.Save(fileName);//luu dl

            }
        }
        public void Xoa(nhaccDTO xoaNcc)
        {
            XmlNode nccCanXoa = root.SelectSingleNode("ncc[mancc ='" + xoaNcc.Mancc + "']");
            if(nccCanXoa != null)
            {
                root.RemoveChild(nccCanXoa);

                doc.Save(fileName);
            }
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 5;
            XmlNodeList ds = root.SelectNodes("ncc");
            int sd = 0;//luu chi so dong
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("mancc").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("tenncc").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("diachi").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("sdt").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("email").InnerText;
                sd++;
            }
        }

    }
}
