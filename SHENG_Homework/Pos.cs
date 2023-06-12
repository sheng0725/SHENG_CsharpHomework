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
    public partial class Pos : Form
    {
        double total = 0 ,CfTotalPrice, CaTotalPrice, BTotalPrice, CkTotalPrice;
        int coffeeprice = 100, cakeprice = 200, breadprice = 150, cookieprice = 80,
             coffeeqty, cakeqty, breadqty, cookieqty;
        string[] allitem = new string[4];
        public Pos()
        {
            InitializeComponent();
        }

        private void btncoffee_Click(object sender, EventArgs e)
        {
            coffeeqty += 1;
            CfTotalPrice += coffeeprice;
            allitem[0] = "咖啡Coffee x" + coffeeqty + ",共NT$ " + CfTotalPrice + " 元" + Environment.NewLine;
            intolist();
        }

        private void btncake_Click(object sender, EventArgs e)
        {
            cakeqty += 1;
            CaTotalPrice += cakeprice;
            allitem[1] = "蛋糕Cake x" + cakeqty + ",共NT$ " + CaTotalPrice + " 元" + Environment.NewLine;
            intolist();
        }

        private void btnbread_Click(object sender, EventArgs e)
        {
            breadqty += 1;
            BTotalPrice += breadprice;
            allitem[2] = "麵包Bread x" + breadqty + ",共NT$ " + BTotalPrice + " 元" + Environment.NewLine;
            intolist();
        }

        private void btncookie_Click(object sender, EventArgs e)
        {

            cookieqty += 1;
            CkTotalPrice += cookieprice;
            allitem[3] = "餅乾Cookie x" + cookieqty + ",共NT$ " + CkTotalPrice + " 元" + Environment.NewLine;
            intolist();
        }
        private void btncash_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐!","確認付款",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額： " + labtotal.Text, "確認付款",MessageBoxButtons.YesNo);
            }
        }

        private void btncard_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額： " + labtotal.Text + '\n' + "折扣後金額： " + "NT$ " + (total * 0.9).ToString(), "確認付款", MessageBoxButtons.YesNo);
            }
        }

        private void btnListclear_Click(object sender, EventArgs e)
        {
            labList.Text = "尚未點餐";
            labtotal.Text = "NT$ 0";
            allitem[0] = "";
            allitem[1] = "";
            allitem[2] = "";
            allitem[3] = "";
            total = 0;
            CfTotalPrice = 0;
            CaTotalPrice = 0;
            BTotalPrice = 0;
            CkTotalPrice = 0;
            coffeeqty = 0;
            cakeqty = 0;
            breadqty = 0;
            cookieqty = 0;
        }

        public void intolist() 
        {
            total = CfTotalPrice + CaTotalPrice + BTotalPrice + CkTotalPrice;
            labtotal.Text = "NT$ " + total.ToString();
            labList.Text = allitem[0] + allitem[1] + allitem[2] + allitem[3];
        }
    }
}
