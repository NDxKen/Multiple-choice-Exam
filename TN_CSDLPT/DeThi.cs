using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT
{
    class DeThi
    {
        private String cauHoi;
        private String noiDung;
        private String a;
        private String b;
        private String c;
        private String d;
        private String dapAn;
        private String daChon;

        public DeThi()
        {
        }

        public DeThi(string cauHoi, string noiDung, string a, string b, string c, string d, string dapAn, string daChon)
        {
            this.cauHoi = cauHoi;
            this.noiDung = noiDung;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.dapAn = dapAn;
            this.DaChon = daChon;
        }

        public string CauHoi { get => cauHoi; set => cauHoi = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public string C { get => c; set => c = value; }
        public string D { get => d; set => d = value; }
        public string DapAn { get => dapAn; set => dapAn = value; }
        public string DaChon { get => daChon; set => daChon = value; }
    }
}
