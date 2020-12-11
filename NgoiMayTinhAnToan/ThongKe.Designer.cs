namespace NgoiMayTinhAnToan
{
    partial class ThongKe
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
            this.dtgvTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labText = new System.Windows.Forms.Label();
            this.labPhutGiay = new System.Windows.Forms.Label();
            this.labGioCH = new System.Windows.Forms.Label();
            this.labCanhBao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTK
            // 
            this.dtgvTK.AllowUserToDeleteRows = false;
            this.dtgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTK.Location = new System.Drawing.Point(12, 205);
            this.dtgvTK.Name = "dtgvTK";
            this.dtgvTK.ReadOnly = true;
            this.dtgvTK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvTK.Size = new System.Drawing.Size(808, 355);
            this.dtgvTK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(107, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê giờ ngồi máy tính";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labText);
            this.groupBox1.Controls.Add(this.labPhutGiay);
            this.groupBox1.Controls.Add(this.labGioCH);
            this.groupBox1.Controls.Add(this.labCanhBao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // labText
            // 
            this.labText.AutoSize = true;
            this.labText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labText.ForeColor = System.Drawing.Color.Blue;
            this.labText.Location = new System.Drawing.Point(372, 29);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(383, 26);
            this.labText.TabIndex = 1;
            this.labText.Text = "Tổng thời gian chơi trong năm 2020 ";
            // 
            // labPhutGiay
            // 
            this.labPhutGiay.AutoSize = true;
            this.labPhutGiay.Font = new System.Drawing.Font("Times New Roman", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labPhutGiay.ForeColor = System.Drawing.Color.Red;
            this.labPhutGiay.Location = new System.Drawing.Point(509, 69);
            this.labPhutGiay.Name = "labPhutGiay";
            this.labPhutGiay.Size = new System.Drawing.Size(0, 36);
            this.labPhutGiay.TabIndex = 1;
            // 
            // labGioCH
            // 
            this.labGioCH.AutoSize = true;
            this.labGioCH.Font = new System.Drawing.Font("Times New Roman", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labGioCH.ForeColor = System.Drawing.Color.Red;
            this.labGioCH.Location = new System.Drawing.Point(371, 69);
            this.labGioCH.Name = "labGioCH";
            this.labGioCH.Size = new System.Drawing.Size(365, 36);
            this.labGioCH.TabIndex = 1;
            this.labGioCH.Text = "1234 Giờ 59 Phút 60 Giây ";
            // 
            // labCanhBao
            // 
            this.labCanhBao.AutoSize = true;
            this.labCanhBao.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labCanhBao.ForeColor = System.Drawing.Color.Red;
            this.labCanhBao.Location = new System.Drawing.Point(153, 92);
            this.labCanhBao.Name = "labCanhBao";
            this.labCanhBao.Size = new System.Drawing.Size(104, 23);
            this.labCanhBao.TabIndex = 1;
            this.labCanhBao.Text = "Nguy Hiểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mức cảnh báo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn năm";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(131, 25);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 30);
            this.cbNam.TabIndex = 0;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTK);
            this.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labText;
        private System.Windows.Forms.Label labPhutGiay;
        private System.Windows.Forms.Label labGioCH;
        private System.Windows.Forms.Label labCanhBao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNam;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}