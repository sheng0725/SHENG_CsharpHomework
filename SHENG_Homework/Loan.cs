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

    public partial class Loan : Form
    {
        int money,year,downpay;
        float rate;
        double r, m_nper, rpn, PMT, allpmt ,PMT2,allpmt2;

        public Loan()
        {
            InitializeComponent();
        }

        public void pay()
        {
            money = int.Parse(txtmoney.Text);
            year = int.Parse(txtyear.Text);
            rate = float.Parse(txtrate.Text);
            downpay = int.Parse(txtdownpay.Text);

            //(x*r^n(r-1))/(r^n-1)
            //(本金*公比^期數(公比-1))/(公比^期數-1)
            //本金*(1+(rate/12/100)^期數*(1+(rate/12/100))-1)/(1+(rate/12/100)-1)
            r = 1.0 + rate / 12 / 100;
            m_nper = year * 12;
            rpn = Math.Pow(r, m_nper);

            PMT = (money - downpay) * rpn * (r - 1) / (rpn - 1);
            allpmt = PMT * m_nper;
            PMT2 = (int)PMT;
            allpmt2 = (int)allpmt;
        }


        private void btnpmt_Click(object sender, EventArgs e)
        {
            pay();
            MessageBox.Show("月付額：" + PMT2);
        }

        private void btnallpay_Click(object sender, EventArgs e)
        {
            pay();
            MessageBox.Show("總付款：" + allpmt2);
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            pay();
            LoanReport frmLoanReport = new LoanReport(money, year, rate, PMT2, allpmt2);
            frmLoanReport.Show();
        }
        
    }
    
}

