using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHENG_Homework
{
    public partial class HomePage : Form
    {

        private Form currentForm; // 儲存目前打開的表單
        private Panel panelShow;
        public HomePage()
        {
            InitializeComponent();
            panelShow = splitContainer2.Panel2;
            // 設定表單初始狀態為最大化
            this.WindowState = FormWindowState.Maximized;
        }

        public void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                // 關閉先前的表單
                currentForm.Close();
                currentForm.Dispose();
            }

            // 設定新的表單
            currentForm = form;
            currentForm.TopLevel = false;// 設定為非頂層表單
            currentForm.FormBorderStyle = FormBorderStyle.Sizable;// 設定有邊框
            currentForm.AutoSize = false; // 可調整視窗大小
            panelShow.Controls.Add(currentForm); //將Form 加入 panelHello 的控制項集合
            currentForm.Show();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Hello frm = new Hello();
            OpenForm(frm);
        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            Loan frm = new Loan();
            OpenForm(frm);
        }

        private void butPos_Click(object sender, EventArgs e)
        {
            Pos frm = new Pos();
            OpenForm(frm);
        }

        private void btnStudentStructForm_Click(object sender, EventArgs e)
        {
            Student_StructForm frm = new Student_StructForm();
            OpenForm(frm);
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            StudentGrade frm = new StudentGrade();
            OpenForm(frm);
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Calculator frm = new Calculator();
            OpenForm(frm);
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            ForDoWhile frm = new ForDoWhile();
            OpenForm(frm);
        }

        private void btnOXGame_Click(object sender, EventArgs e)
        {
            OXGame frm = new OXGame();
            OpenForm(frm);
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            ScreenSaver frm = new ScreenSaver();
            frm.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            Notepad frm = new Notepad();
            frm.Show();

        }

        private void btn小畫家_Click(object sender, EventArgs e)
        {
            Graffiti frm = new Graffiti();  
            OpenForm(frm);
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            PictureViewer frm = new PictureViewer();
            OpenForm(frm);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess frm = new Guess();
            OpenForm(frm);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Alarm frm = new Alarm();
            OpenForm(frm);
        }
    }
}
