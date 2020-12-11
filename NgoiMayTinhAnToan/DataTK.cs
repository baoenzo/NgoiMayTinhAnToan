using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoiMayTinhAnToan
{
    public class DataTK
    {
        public string Ngay { get; set; }
        public string Thang { get; set; }
        public string Nam { get; set; }

        public string ThoiGianBD { get; set; }
        public string ThoiGianKT { get; set; }
        public string GioChoi { get; set; }

        public DataTK(string ngay, string thang, string nam, string thoigianbd,string thoigiankt, string gio) {
            this.Nam = nam;
            this.Thang = thang;
            this.Ngay = ngay;
            this.ThoiGianBD = thoigianbd;
            this.ThoiGianKT = thoigiankt;
            this.GioChoi = gio;
        }
        public DataTK() { }
    }
}
