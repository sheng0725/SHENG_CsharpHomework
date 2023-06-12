using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SHENG_Homework
{
    public partial class Hello : Form
    {
        string cname, enname, sex, con;
        public Hello()
        {
            InitializeComponent();
            cname = txtcname.Text;
            enname = txtenname.Text;
            sex = txtsex.Text;
            con = txtcon.Text;
        }

        private void btnSHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, 我是," + cname + '\n' + 
                                              "英文名字是 " + enname + '\n' +
                                              "性別是, " + sex + '\n' +
                                              "星座是, " + con + '\n' +
                                              "很高興認識你。");
        }

        private void btnSHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, 我是," + cname + '\n' +
                                              "英文名字是 " + enname + '\n' +
                                              "性別是, " + sex + '\n' +
                                              "星座是, " + con + '\n' +
                                              "很高興認識你。");
        }
    }
}
