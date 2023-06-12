using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHENG_Homework
{
    
    public partial class LoanReport : Form
    {
       
        public LoanReport(int money, int year, double rate, double PMT, double allpmt)
        {
            InitializeComponent();
            labmoney.Text = money.ToString();
            labyear.Text = year.ToString();
            labrate.Text = rate.ToString();
            labmonpay.Text = PMT.ToString();
            laballpay.Text = allpmt.ToString();
        }

    }
    
}
