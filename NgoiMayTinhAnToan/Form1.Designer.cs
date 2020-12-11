namespace NgoiMayTinhAnToan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labGio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.labDemNguoc = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnThongKe = new System.Windows.Forms.Button();
            this.timerToEndd = new System.Windows.Forms.Timer(this.components);
            this.rbGame = new System.Windows.Forms.RadioButton();
            this.rbDownload = new System.Windows.Forms.RadioButton();
            this.rbWeb = new System.Windows.Forms.RadioButton();
            this.grB = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(20, 318);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 47);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(321, 318);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số giờ ngồi máy tính:";
            // 
            // labGio
            // 
            this.labGio.AutoSize = true;
            this.labGio.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labGio.Location = new System.Drawing.Point(285, 43);
            this.labGio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labGio.Name = "labGio";
            this.labGio.Size = new System.Drawing.Size(110, 31);
            this.labGio.TabIndex = 1;
            this.labGio.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian: ";
            // 
            // txtGio
            // 
            this.txtGio.Enabled = false;
            this.txtGio.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGio.Location = new System.Drawing.Point(157, 101);
            this.txtGio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(134, 35);
            this.txtGio.TabIndex = 2;
            this.txtGio.Text = "45";
            this.txtGio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(299, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "phút";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(356, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "|";
            // 
            // labDemNguoc
            // 
            this.labDemNguoc.AutoSize = true;
            this.labDemNguoc.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDemNguoc.Location = new System.Drawing.Point(379, 104);
            this.labDemNguoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labDemNguoc.Name = "labDemNguoc";
            this.labDemNguoc.Size = new System.Drawing.Size(76, 31);
            this.labDemNguoc.TabIndex = 1;
            this.labDemNguoc.Text = "00:00";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Chương trình đã ẩn xuống thanh System";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(172, 318);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(112, 47);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // timerToEndd
            // 
            this.timerToEndd.Enabled = true;
            this.timerToEndd.Interval = 10;
            this.timerToEndd.Tick += new System.EventHandler(this.timerToEndd_Tick);
            // 
            // rbGame
            // 
            this.rbGame.AutoSize = true;
            this.rbGame.Location = new System.Drawing.Point(42, 49);
            this.rbGame.Name = "rbGame";
            this.rbGame.Size = new System.Drawing.Size(95, 35);
            this.rbGame.TabIndex = 3;
            this.rbGame.TabStop = true;
            this.rbGame.Text = "Game";
            this.rbGame.UseVisualStyleBackColor = true;
            // 
            // rbDownload
            // 
            this.rbDownload.AutoSize = true;
            this.rbDownload.Location = new System.Drawing.Point(167, 48);
            this.rbDownload.Name = "rbDownload";
            this.rbDownload.Size = new System.Drawing.Size(146, 35);
            this.rbDownload.TabIndex = 3;
            this.rbDownload.TabStop = true;
            this.rbDownload.Text = "Download";
            this.rbDownload.UseVisualStyleBackColor = true;
            // 
            // rbWeb
            // 
            this.rbWeb.AutoSize = true;
            this.rbWeb.Checked = true;
            this.rbWeb.Location = new System.Drawing.Point(337, 49);
            this.rbWeb.Name = "rbWeb";
            this.rbWeb.Size = new System.Drawing.Size(83, 35);
            this.rbWeb.TabIndex = 3;
            this.rbWeb.TabStop = true;
            this.rbWeb.Text = "Web";
            this.rbWeb.UseVisualStyleBackColor = true;
            // 
            // grB
            // 
            this.grB.Controls.Add(this.rbWeb);
            this.grB.Controls.Add(this.rbGame);
            this.grB.Controls.Add(this.rbDownload);
            this.grB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grB.Location = new System.Drawing.Point(13, 189);
            this.grB.Name = "grB";
            this.grB.Size = new System.Drawing.Size(456, 99);
            this.grB.TabIndex = 4;
            this.grB.TabStop = false;
            this.grB.Text = "Chế độ";
            this.grB.Enter += new System.EventHandler(this.grB_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labDemNguoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labGio);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 155);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng quan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnEdit);
            this.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngồi máy tính an toàn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.grB.ResumeLayout(false);
            this.grB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labGio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labDemNguoc;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Timer timerToEndd;
        private System.Windows.Forms.RadioButton rbGame;
        private System.Windows.Forms.RadioButton rbDownload;
        private System.Windows.Forms.RadioButton rbWeb;
        private System.Windows.Forms.GroupBox grB;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

