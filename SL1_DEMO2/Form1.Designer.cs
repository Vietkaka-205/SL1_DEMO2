namespace SL1_DEMO2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltHoTen = new System.Windows.Forms.Label();
            this.lblBoMon = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radWeb = new System.Windows.Forms.RadioButton();
            this.radGame = new System.Windows.Forms.RadioButton();
            this.radPTPM = new System.Windows.Forms.RadioButton();
            this.radXLDL = new System.Windows.Forms.RadioButton();
            this.radUDPM = new System.Windows.Forms.RadioButton();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtBoMon = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // lbltHoTen
            // 
            this.lbltHoTen.AutoSize = true;
            this.lbltHoTen.Location = new System.Drawing.Point(25, 65);
            this.lbltHoTen.Name = "lbltHoTen";
            this.lbltHoTen.Size = new System.Drawing.Size(52, 16);
            this.lbltHoTen.TabIndex = 1;
            this.lbltHoTen.Text = "Họ Tên";
            this.lbltHoTen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBoMon
            // 
            this.lblBoMon.AutoSize = true;
            this.lblBoMon.Location = new System.Drawing.Point(25, 99);
            this.lblBoMon.Name = "lblBoMon";
            this.lblBoMon.Size = new System.Drawing.Size(53, 16);
            this.lblBoMon.TabIndex = 2;
            this.lblBoMon.Text = "Bộ Môn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Location = new System.Drawing.Point(28, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới Tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(182, 21);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 1;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(7, 19);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(60, 20);
            this.radNam.TabIndex = 0;
            this.radNam.Text = "Nam ";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chuyên Ngành";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.radWeb);
            this.flowLayoutPanel1.Controls.Add(this.radGame);
            this.flowLayoutPanel1.Controls.Add(this.radPTPM);
            this.flowLayoutPanel1.Controls.Add(this.radXLDL);
            this.flowLayoutPanel1.Controls.Add(this.radUDPM);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 268);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 115);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // radWeb
            // 
            this.radWeb.AutoCheck = false;
            this.radWeb.AutoSize = true;
            this.radWeb.Location = new System.Drawing.Point(3, 3);
            this.radWeb.Name = "radWeb";
            this.radWeb.Size = new System.Drawing.Size(116, 20);
            this.radWeb.TabIndex = 1;
            this.radWeb.TabStop = true;
            this.radWeb.Text = "Lập Trình Web";
            this.radWeb.UseVisualStyleBackColor = true;
            // 
            // radGame
            // 
            this.radGame.AutoSize = true;
            this.radGame.Location = new System.Drawing.Point(3, 29);
            this.radGame.Name = "radGame";
            this.radGame.Size = new System.Drawing.Size(124, 20);
            this.radGame.TabIndex = 2;
            this.radGame.TabStop = true;
            this.radGame.Text = "Lập Trình Game";
            this.radGame.UseVisualStyleBackColor = true;
            // 
            // radPTPM
            // 
            this.radPTPM.AutoSize = true;
            this.radPTPM.Location = new System.Drawing.Point(3, 55);
            this.radPTPM.Name = "radPTPM";
            this.radPTPM.Size = new System.Drawing.Size(156, 20);
            this.radPTPM.TabIndex = 3;
            this.radPTPM.TabStop = true;
            this.radPTPM.Text = "Phát Triển Phần Mềm";
            this.radPTPM.UseVisualStyleBackColor = true;
            // 
            // radXLDL
            // 
            this.radXLDL.AutoSize = true;
            this.radXLDL.Location = new System.Drawing.Point(3, 81);
            this.radXLDL.Name = "radXLDL";
            this.radXLDL.Size = new System.Drawing.Size(104, 20);
            this.radXLDL.TabIndex = 4;
            this.radXLDL.TabStop = true;
            this.radXLDL.Text = "Xử Lí Dữ Liệu";
            this.radXLDL.UseVisualStyleBackColor = true;
            // 
            // radUDPM
            // 
            this.radUDPM.AutoSize = true;
            this.radUDPM.Location = new System.Drawing.Point(3, 107);
            this.radUDPM.Name = "radUDPM";
            this.radUDPM.Size = new System.Drawing.Size(136, 20);
            this.radUDPM.TabIndex = 5;
            this.radUDPM.TabStop = true;
            this.radUDPM.Text = "Ứng Dụng Dữ Liệu";
            this.radUDPM.UseVisualStyleBackColor = true;
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(28, 415);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(75, 23);
            this.btnDangKi.TabIndex = 6;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(196, 415);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNoiDung);
            this.groupBox2.Location = new System.Drawing.Point(465, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 244);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đăng Kí";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(17, 32);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(238, 192);
            this.txtNoiDung.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(87, 65);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(244, 22);
            this.txtHoTen.TabIndex = 11;
            // 
            // txtBoMon
            // 
            this.txtBoMon.Location = new System.Drawing.Point(87, 99);
            this.txtBoMon.Multiline = true;
            this.txtBoMon.Name = "txtBoMon";
            this.txtBoMon.Size = new System.Drawing.Size(244, 22);
            this.txtBoMon.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoMon);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBoMon);
            this.Controls.Add(this.lbltHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đăng Kí Chuyển Ngành";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltHoTen;
        private System.Windows.Forms.Label lblBoMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radWeb;
        private System.Windows.Forms.RadioButton radGame;
        private System.Windows.Forms.RadioButton radPTPM;
        private System.Windows.Forms.RadioButton radXLDL;
        private System.Windows.Forms.RadioButton radUDPM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtBoMon;
    }
}

