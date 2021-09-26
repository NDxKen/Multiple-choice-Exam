using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT
{
    class CauHoi
    {
        private String idCauHoi;
        private String maMH;
        private String trinhDo;
        private String noiDung;
        private String a;
        private String b;
        private String c;
        private String d;
        private String dapAn;
        private String daChon;
        private String maGV;

        public CauHoi(string idCauHoi, string maMH, string trinhDo, string noiDung, string a, string b, string c, string d, string dapAn, string daChon, string maGV)
        {
            this.idCauHoi = idCauHoi;
            this.maMH = maMH;
            this.trinhDo = trinhDo;
            this.noiDung = noiDung;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.dapAn = dapAn;
            this.daChon = daChon;
            this.maGV = maGV;
        }

        public string IdCauHoi { get => idCauHoi; set => idCauHoi = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public string C { get => c; set => c = value; }
        public string D { get => d; set => d = value; }
        public string DapAn { get => dapAn; set => dapAn = value; }
        public string DaChon { get => daChon; set => daChon = value; }
        public string MaGV { get => maGV; set => maGV = value; }
    }
}
