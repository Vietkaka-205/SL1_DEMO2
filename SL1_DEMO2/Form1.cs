using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL1_DEMO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";string str = "";
            str = "Họ tên :" + txtHoTen.Text + "\r\nBộ Môn :" + txtBoMon.Text + "\r\n";
            if (radNam.Checked == true) str = str + "Giới Tính :Nam\r\n";
            if (radNu.Checked == true) str = str + "Giới Tính :Nu\r\n";
            str = str + "Chuyên Ngành :";
            if (radWeb.Checked == true) str = str + "Lập Trình web";
            if (radGame.Checked == true) str = str + "Lập Trình Game";
            if (radPTPM.Checked == true) str = str + "Phát Triển Phần Mềm";
            if (radXLDL.Checked == true) str = str + "Xử Lí Dữ Liệu";
            if (radUDPM.Checked == true) str = str + " Ứng Dụng Phần Mềm";
            txtNoiDung.Text = str;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
