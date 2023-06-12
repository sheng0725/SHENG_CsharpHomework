using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;

namespace SHENG_Homework
{
    public partial class Student_StructForm : Form
    {
        string name,maxsubject,minsubject;
        int[] score = new int[3] {0,0,0};
        int max, min, which;
        public Student_StructForm()
        {
            InitializeComponent();
            maxsubject = minsubject = "數學";
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            Resetdata();
        }

        private void btnStoreShow_Click(object sender, EventArgs e)
        {
            labscore.Text = $"姓名：{name} \r國文：{score[0]} \r英文：{score[1]} \r數學：{score[2]}";
        }

        private void butmaxmin_Click(object sender, EventArgs e)
        {
            labmaxmin.Text = $"最高科目成績為：{maxsubject}{max}分\r最低科目成績為：{minsubject}{min}分";
        }

        public void Resetdata()
        {
            name = txtName.Text;
            score[0] = int.Parse(txtCN.Text);
            score[1] = int.Parse(txtEN.Text);
            score[2] = int.Parse(txtMath.Text);
            max = min = score[2];
            maxsubject = minsubject = "數學";

            for (which = 0; which < 3; which++)
            {
                if (max < score[which])
                {
                    /*判斷num[i]是否大於Max*/
                    max = score[which];
                    switch (which)
                    {
                        case 0:
                            maxsubject = "國文";
                            break;
                        case 1:
                            maxsubject = "英文";
                            break;
                        case 2:
                            maxsubject = "數學";
                            break;
                    }
                }
                /*是的話將num[i的值放入Max保持Max的值為最大*/
                if (min > score[which])
                {
                    min = score[which];
                    switch (which)
                    {
                        case 0:
                            minsubject = "國文";
                            break;
                        case 1:
                            minsubject = "英文";
                            break;
                        case 2:
                            minsubject = "數學";
                            break;
                    }
                }
            }
        }
    }
}
