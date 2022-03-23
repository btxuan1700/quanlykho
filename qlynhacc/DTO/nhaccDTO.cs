using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlynhacc.DTO
{
    public class nhaccDTO
    {
        private string _Mancc;
        private string _Tenncc;
        private string _Diachi;
        private string _Sdt;
        private string _Email;

        public string Mancc { get => _Mancc; set => _Mancc = value; }
        public string Tenncc { get => _Tenncc; set => _Tenncc = value; }
        public string Diachi { get => _Diachi; set => _Diachi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
