using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgoiMayTinhAnToan
{
    public partial class ThongKe : Form
    {
        // string pathFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/Antoan";
        string pathFile = Application.StartupPath + @"/Antoan";
        string dataFile;
        string currentYear;
        List<string> lstTK = new List<string>();
        List<TimeD> lstTime= new List<TimeD>();
        BindingSource source;
        public ThongKe()
        {
            InitializeComponent();
            KhoiTaoCB();
            dataFile = pathFile + @"/thongke.txt";
        }


        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadData();

            LoadDataGV();

           labGioCH.Text = TinhGioChoi(false);
        }

        private void LoadDataGV()
        {
            var list = new BindingList<DataTK>(GetData("2020"));
            source = new BindingSource(list, null);
            dtgvTK.DataSource = source;
            InitDataGridView();

        }
        private void LoadData()
        {
            if(File.Exists(dataFile))
            {
               lstTK = File.ReadAllLines(dataFile).ToList();
            }
        }
        private void InitDataGridView()
        {
            dtgvTK.Columns["Ngay"].HeaderText = "Ngày";
            dtgvTK.Columns["Ngay"].Width = 80;

            dtgvTK.Columns["Thang"].HeaderText = "Tháng";
            dtgvTK.Columns["Thang"].Width = 80;


            dtgvTK.Columns["Nam"].HeaderText = "Năm";
            dtgvTK.Columns["Nam"].Width = 80;

            dtgvTK.Columns["ThoiGianBD"].HeaderText = "Thời gian bắt đầu";
            dtgvTK.Columns["ThoiGianBD"].Width = 180;


            dtgvTK.Columns["ThoiGianKT"].HeaderText = "Thời gian kết thúc";
            dtgvTK.Columns["ThoiGianKT"].Width = 180;

            dtgvTK.Columns["GioChoi"].HeaderText = "Số giờ chơi";
            dtgvTK.Columns["GioChoi"].Width = 165;
        }
        void KhoiTaoCB()
        {
            for (int i = 2020; i <= 2100; i++)
            {
                cbNam.Items.Add(i);
            }
            cbNam.SelectedIndex = 0; 
        }
        private List<DataTK> GetData(string nam = null)
        {
            List<DataTK> lstData = new List<DataTK>();
            lstTime.Clear();
            for (int i = 0; i < lstTK.Count; i++)
            {
                DataTK dt = new DataTK();
                string[] temp = lstTK[i].Split('$');
                dt.ThoiGianKT = temp[1].Trim();

                // số giờ chơi
                dt.GioChoi = temp[2].Trim();
                string[] timeTemp = Tach(dt.GioChoi, false);


                // Thoi gian bat dau
                string[] tempBD = temp[0].Split(' ');
                dt.ThoiGianBD = tempBD[1];


                string[] tempDate = Tach(tempBD[0], true);
                dt.Ngay = tempDate[0];
                dt.Thang = tempDate[1];
                dt.Nam = tempDate[2];
                if (dt.Nam == nam)
                {
                    lstTime.Add(new TimeD(Int32.Parse(timeTemp[0]), Int32.Parse(timeTemp[1]), Int32.Parse(timeTemp[2])));
                }
                
                lstData.Add(dt);
            }
            return lstData;
        }


        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nam = cbNam.SelectedItem.ToString();
            labText.Text = "Tổng thời gian chơi trong năm " + nam;
            var list = new BindingList<DataTK>(FilterNam(nam));
            BindingSource sourceFilter = new BindingSource(list, null);
            dtgvTK.DataSource = sourceFilter;

            if (dtgvTK.Rows.Count > 1)
            {
                GetData(nam);
                labGioCH.Text = TinhGioChoi(false);
            }
            else
            {
                lstTime.Clear();
                labGioCH.Text = TinhGioChoi(true);
            }
        }

        private List<DataTK> FilterNam(string nam)
        {
            List<DataTK> lstData = GetData();
            List<DataTK> lstFilter = new List<DataTK>();
            for (int i = 0; i < lstData.Count; i++)
            {
                if(lstData[i].Nam == nam)
                {
                    lstFilter.Add(lstData[i]);
                }
            }
            return lstFilter;
        }

        private string[] Tach(string text , bool isNam)
        {
            if(isNam)
            {
                return text.Trim().Split('-');
            }
            else
                return text.Trim().Split(':');
        }

        private string TinhGioChoi(bool isDataGridViewNull)
        {
            //string[] tempGio = text.Trim().Split(':');
            //int gio = Int32.Parse(tempGio[0]);
            //int phút = Int32.Parse(tempGio[1]);
            //int giay = Int32.Parse(tempGio[2]);

            //Tính phút tạm: phuttam = Total(giay) / 60;
            // Giay = Total(giay) % 60;
            // Phút thực = Phút + Phuttam;

            // Gio = Tổng phut / 60;
            // Phút còn dư + phút cũ
            string kq ="";
            int gio = 0, phut = 0, giay = 0, totalGio = 0, totalPhut = 0, totalGiay = 0;
            if (!isDataGridViewNull)
            {

                for (int i = 0; i < lstTime.Count; i++)
                {
                    totalGio += lstTime[i].Gio;
                    totalPhut += lstTime[i].Phut;
                    totalGiay += lstTime[i].Giay;
                }

                int giayTam = totalGiay % 60;
                phut = (totalGiay / 60);

                giay = giayTam;

                int phutTam = totalPhut % 60;
                gio = (totalPhut / 60);

                phut += phutTam;

                gio += totalGio;
                kq = gio + " Giờ " + phut + " Phút " + giay + " Giây";
            }
            else
            {
                kq = 0 + " Giờ " + 0 + " Phút " + 0 + " Giây";
            }
            return kq;
        }
    }

    class TimeD
    {
        public int Gio { get; set; }
        public int Phut { get; set; }
        public int Giay { get; set; }
        
        public TimeD(int gio, int p , int giay)
        {
            this.Gio = gio;
            this.Phut = p;
            this.Giay = giay;
        }
    }
}
