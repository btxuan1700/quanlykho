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
    internal class dangnhapBLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
       
        string fileName = @"C:\Users\Admin\source\repos\qlynhacc\qlynhacc\dangnhap.xml";

        public dangnhapBLL()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public Boolean dangnhap(dangnhapDTO login)
        {
            XmlNode tkdn = root.SelectSingleNode("taikhoan[tk = '" + login.Tk + "']");
            XmlNode mk = root.SelectSingleNode("taikhoan[matkhau = '" + login.Makhau + "']");

            int cout = 0;
            if(tkdn != null && mk != null)
            {
                cout++;
            }
            if(cout >0)
            {
                return true;
            }
            return false;
        }
     

    }
}
