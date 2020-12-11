using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace NgoiMayTinhAnToan
{
    public partial class Form1 : Form
    {
        string currentTime;
        private int timeLeft = 45;
        TimeSpan t3, t2, t1;
        string startTime;
        bool flag = false;
        // string pathFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/Antoan";
        string pathFile = Application.StartupPath + @"/Antoan";
        string dataFile;
        public Form1()
        {
            InitializeComponent();
            GhiFile();
            startTime = DateTime.Now.ToString("dd-MM-yyy HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataFile = pathFile + @"\data.dat";
            DocFile();
            SumTime();
            if (!CheckLineText())
            {
                MessageBox.Show("File text quá lớn! Vui lòng di chuyển chổ khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!rbDownload.Checked)
            {
                labGio.Text = DateTime.Now.ToString("HH:mm:ss");
                if (labGio.Text == t3.ToString())
                {
                    flag = true;
                    SumTime();
                    if (!rbGame.Checked)
                    {
                        this.Show();
                        this.WindowState = FormWindowState.Normal;
                        MessageBox.Show(string.Format("Đã qua {0} phút!!! Hãy đứng dậy và đi vòng vòng \r\nNhìn ra xa {0} trong {0] giây", txtGio.Text), string.Format("Đã qua {0} phút!!!", txtGio.Text), MessageBoxButtons.OK);
                        // this.WindowState = FormWindowState.Minimized;
                    }
                }
                if (flag)
                {
                    if (timeLeft > 0)
                    {
                        timeLeft = timeLeft - 1;
                        var timespan = TimeSpan.FromSeconds(timeLeft);
                        labDemNguoc.Text = timespan.ToString(@"mm\:ss");
                    }
                    else
                    {
                        timeLeft = 45;
                        flag = false;
                    }
                }
            }
        }



        #region Event
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtGio.Enabled = !txtGio.Enabled;
            if (!txtGio.Enabled)
            {
                File.WriteAllText(pathFile + @"\data.dat", txtGio.Text);
            }
        }
        #endregion

        #region Method
        private void GhiFile()
        {
            if (!Directory.Exists(pathFile))
            {
                Directory.CreateDirectory(pathFile);
            }
        }

        private void DocFile()
        {
            if (File.Exists(dataFile))
            {
                string temp = File.ReadAllText(dataFile);
                txtGio.Text = temp;
            }
        }
        private void SumTime()
        {
            currentTime = DateTime.Now.ToString("HH:mm:ss");
            t1 = TimeSpan.Parse(currentTime);
            t2 = TimeSpan.Parse(string.Format("00:{0}:00", txtGio.Text));
            t3 = t1.Add(t2);
        }

        private void timerToEndd_Tick(object sender, EventArgs e)
        { 
            AppRunning();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string dt = DateTime.Now.ToString("HH:mm:ss");
            TextWriter tsw = new StreamWriter(pathFile + @"\thongke.txt", true);

            TimeSpan t4 = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
            TimeSpan t5 = TimeSpan.Parse(startTime.Split(' ').ToArray().ElementAt(1));
            TimeSpan t6 = t4.Subtract(t5);

          
            tsw.WriteLine(startTime +" $ " + dt + " $ " + t6);
            tsw.Close();
        }

        private void ThongKe()
        {
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
        }
        
        private void AppRunning()
        {
            if(isRunning() == false)
            {
                string dt = DateTime.Now.ToString("HH:mm:ss");
                TextWriter tsw = new StreamWriter(pathFile + @"\thongke.txt", true);
                tsw.WriteLine(dt);
                tsw.Close();
            }
        }

        private void grB_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            //to hide from taskbar
            this.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }

        private bool isRunning()
        {
            Process[] allProcesses = Process.GetProcesses();
            int co = 0;
            foreach (Process pr in allProcesses)
            {
                if (pr.ProcessName.Contains("NgoiMayTinhAnToan"))
                {
                    co = 1;
                    break;
                }
            }
            if (co == 1)
                return true;
            return false;
        }

        private bool CheckLineText()
        {
            List<string> lstTemp = new List<string>() ;
            if(File.Exists(pathFile + @"\thongke.txt"))
            {
                lstTemp = File.ReadAllLines( pathFile + @"\thongke.txt").ToList();
            }
            if(lstTemp.Count > 0  )
            {
                if (lstTemp.Count > 3000000)
                    return false;
            }
            return true;
        }
        #endregion
    }
}
